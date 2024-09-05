using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Base;

namespace YazilimciPazari.Backend.Domain.DTOs.Concrete.UserComment
{
    public sealed record AddUserCommentDTO : AddDTO
    {
        public Guid UserId { get; init; }
        public Guid CommentId { get; init; }
    }
}
