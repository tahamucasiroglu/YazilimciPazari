using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.User;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Domain.Returns.Abstract;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Base;

namespace YazilimciPazari.Backend.Service.DatabaseService.Concrete
{
    public class UserService : Service<User, GetUserDTO, AddUserDTO, UpdateUserDTO>, IUserService
    {
        internal readonly IUserRepository repository;
        public UserService(IUserRepository repository, IMapper mapper, IConfiguration configuration) : base(repository, mapper, configuration)
        {
            this.repository = repository;
        }

        public Task<IReturn> GetUserByRefreshToken(RefreshTokenDTO refreshToken)
        {
            throw new ArgumentNullException();
        }
    }
}
