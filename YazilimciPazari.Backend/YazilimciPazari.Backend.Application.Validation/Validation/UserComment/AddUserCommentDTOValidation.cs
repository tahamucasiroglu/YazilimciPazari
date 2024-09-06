using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.UserComment;

namespace YazilimciPazari.Backend.Application.Validation.Validation.UserComment
{
    public class AddUserCommentDTOValidation : AddValidation<AddUserCommentDTO>
    {
        public AddUserCommentDTOValidation() : base() 
        {
            RuleFor(e => e.UserId).IdValidation();
            RuleFor(e => e.CommentId).IdValidation();
        }
    }
}
