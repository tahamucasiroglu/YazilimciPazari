using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;

namespace YazilimciPazari.Backend.Domain.DTOs.Base
{
    abstract public record ResponseDTO : DTO, IResponseDTO
    {
    }
}
