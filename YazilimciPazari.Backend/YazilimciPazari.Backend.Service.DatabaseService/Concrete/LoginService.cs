using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using YazilimciPazari.Backend.Application.Mapper.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.User;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Domain.Returns.Abstract;
using YazilimciPazari.Backend.Domain.Returns.Concrete;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Extension;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace YazilimciPazari.Backend.Service.DatabaseService.Concrete
{
    public class LoginService : Service.DatabaseService.Base.Service, ILoginService
    {
        private readonly UserManager<User> userManager;
        private readonly IConfiguration configuration;
        internal readonly IMapper mapper;
        private readonly string salt;
        public LoginService(UserManager<User> userManager, IMapper mapper, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.mapper = mapper;
            this.salt = configuration["Salt"] ?? throw new ArgumentNullException("Login Service -> Constructor -> Salt boş");
        }
        public void Dispose()
        {
            userManager.Dispose();
        }

        public async Task<IReturn<string>> LoginAsync(LoginUserDTO loginDTO)
        {
            User? user = await userManager.FindByEmailAsync(loginDTO.Email);

            if (user != null && await userManager.CheckPasswordAsync(user, loginDTO.Password.PasswordEncrypt(salt)))
            {
                var token = await GenerateJwtToken(user);
                return new SuccessReturn<string>(token, "Başarılı");
            }
            else
            {
                return new ErrorReturn<string>();
            }
        }

        public async Task<IReturn> RegisterAsync(RegisterUserDTO registerDTO)
        {
            IdentityResult result = await userManager.CreateAsync(registerDTO.ConvertToEntity(mapper), registerDTO.Password.PasswordEncrypt(salt));
            if (result.Succeeded)
            {
                return new SuccessReturn("Kayıt Başarılı");
            }
            else
            {
                int counter = 0;
                string errorText = "Kayıt Sırasında Hata Oldu | Errors | ";
                foreach (var item in result.Errors)
                {
                    errorText += "Error " + counter + "   Code = " + item.Code + "  Description = " + item.Description + "   ||||   ";
                    counter++;
                }
                return new ErrorReturn(errorText);
            }
        }

        private async Task<string> GenerateJwtToken(User user)
        {
            var jwtSettings = configuration.GetSection("JwtSettings");
            var key = Encoding.ASCII.GetBytes(jwtSettings["SecurityKey"] ?? throw new ArgumentNullException("Login Service -> GenerateJwtToken -> Secret Key null"));

            List<Claim> claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email ?? throw new ArgumentNullException("Login Service -> GenerateJwtToken -> Login email boş")),
                new Claim(ClaimTypes.Name, user.FullName ?? throw new ArgumentNullException("Login Service -> GenerateJwtToken -> Secret Key null"))
            };

            // Kullanıcının rollerini eklemek isterseniz
            IList<string> roles = await userManager.GetRolesAsync(user);
            foreach (string role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(int.Parse(jwtSettings["ExpiresInMinutes"] ?? throw new ArgumentNullException("Login Service -> GenerateJwtToken -> ExpiresInMinutes null"))),
                Issuer = jwtSettings["Issuer"],
                Audience = jwtSettings["Audience"],
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
