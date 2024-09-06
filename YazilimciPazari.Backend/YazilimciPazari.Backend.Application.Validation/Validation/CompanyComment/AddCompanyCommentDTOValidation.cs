using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanyComment;

namespace YazilimciPazari.Backend.Application.Validation.Validation.CompanyComment
{
    public class AddCompanyCommentDTOValidation : AddValidation<AddCompanyCommentDTO>
    {
        public AddCompanyCommentDTOValidation() : base() 
        {
            RuleFor(e => e.CompanyId).IdValidation();
            RuleFor(e => e.CommentId).IdValidation();
        }
    }
}
