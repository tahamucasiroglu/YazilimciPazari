using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.User;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Base;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Concrete
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(SqlServerContext context) : base(context) 
        {

        }

        public User GetUserByRefreshToken(RefreshTokenDTO refreshToken)
        {
            return context.Set<User>().First(e => e.RefreshToken == refreshToken.RefreshToken);
        }

        public async Task<User> GetUserByRefreshTokenAsync(RefreshTokenDTO refreshToken)
        {
            return await context.Set<User>().FirstAsync(e => e.RefreshToken == refreshToken.RefreshToken);
        }
    }
}
