using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.UserComment;

namespace YazilimciPazari.Backend.Application.Validation.Validation.UserComment
{
    public class UpdateUserCommentDTOValidation : UpdateValidation<UpdateUserCommentDTO>
    {
        public UpdateUserCommentDTOValidation() : base()
        {
            
        }
    }
}
