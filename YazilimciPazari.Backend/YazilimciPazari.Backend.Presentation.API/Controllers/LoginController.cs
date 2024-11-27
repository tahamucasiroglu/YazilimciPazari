using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.User;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Concrete;
using Controller = YazilimciPazari.Backend.Presentation.API.Controllers.Base.Controller;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        internal ILoginService loginService;
        public LoginController(ILoginService loginService) : base(loginService)
        {
            this.loginService = loginService;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterUserDTO model)
        {
            return new OkObjectResult(await loginService.RegisterAsync(model));
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginUserDTO model)
        {
            return new OkObjectResult(await loginService.LoginAsync(model));
        }

        [HttpPost("[action]")]
        public IActionResult RefreshToken([FromBody] RefreshTokenRequest request)
        {
            // Refresh token doğrulama ve yeni JWT oluşturma
            var user = _userService.GetUserByRefreshToken(request.RefreshToken);
            if (user == null)
            {
                return Unauthorized();
            }

            var newJwtToken = _loginService.GenerateJwtToken(user);
            return Ok(new { token = newJwtToken });
        }
    }
}
