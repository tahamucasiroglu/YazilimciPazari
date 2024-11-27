using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Base;

namespace YazilimciPazari.Backend.Domain.DTOs.Concrete.User
{
    public sealed record RefreshTokenDTO : DTO
    {
        public string RefreshToken { get; set; } = string.Empty;
    }
}
