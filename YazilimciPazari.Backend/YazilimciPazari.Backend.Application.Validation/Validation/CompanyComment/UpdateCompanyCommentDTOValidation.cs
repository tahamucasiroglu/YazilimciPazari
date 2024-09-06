using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanyComment;

namespace YazilimciPazari.Backend.Application.Validation.Validation.CompanyComment
{
    public class UpdateCompanyCommentDTOValidation : UpdateValidation<UpdateCompanyCommentDTO>
    {
        public UpdateCompanyCommentDTOValidation() : base()
        {

        }
    }
}
