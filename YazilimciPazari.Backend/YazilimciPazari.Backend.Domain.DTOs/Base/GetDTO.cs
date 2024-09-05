using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Abstract;

namespace YazilimciPazari.Backend.Domain.DTOs.Base
{
    abstract public record GetDTO : DTO, IGetDTO
    {
        public Guid Id { get; init; }
        public DateTime CreateDate { get; init; }
        public DateTime? UpdateDate { get; init; }
        public DateTime? DeleteDate { get; init; }
        public bool IsDeleted { get; init; }
    }
}
