using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Base;

namespace YazilimciPazari.Backend.Domain.DTOs.Concrete.Comment
{
    public sealed record GetCommentDTO : GetDTO
    {
        public string Text { get; init; } = string.Empty;
    }
}
