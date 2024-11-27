using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Base;

namespace YazilimciPazari.Backend.Domain.DTOs.Concrete.User
{
    public sealed record RegisterUserDTO : DTO
    {
        public string Name { get; init; } = string.Empty;
        public string Surname {  get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public string Username => Email;
        public string Password { get; init; } = string.Empty;
    }
}
