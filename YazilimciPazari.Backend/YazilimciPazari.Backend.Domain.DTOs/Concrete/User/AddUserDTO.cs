using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Base;

namespace YazilimciPazari.Backend.Domain.DTOs.Concrete.User
{
    public sealed record AddUserDTO : AddDTO
    {
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public string IdentityNumber { get; init; } = string.Empty;
        public string Password { get; init; } = string.Empty;
        public string Address { get; init; } = string.Empty;
        public string Website { get; init; } = string.Empty;
    }
}
