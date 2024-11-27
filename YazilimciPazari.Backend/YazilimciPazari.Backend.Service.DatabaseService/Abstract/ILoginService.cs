using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.User;
using YazilimciPazari.Backend.Domain.Returns.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract.Base;

namespace YazilimciPazari.Backend.Service.DatabaseService.Abstract
{
    public interface ILoginService : IService
    {
        public Task<IReturn> RegisterAsync(RegisterUserDTO entity);
        public Task<IReturn<string>> LoginAsync(LoginUserDTO entity);
    }
}
