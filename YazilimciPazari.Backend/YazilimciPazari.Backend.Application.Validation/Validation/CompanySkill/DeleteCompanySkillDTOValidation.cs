using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanySkill;

namespace YazilimciPazari.Backend.Application.Validation.Validation.CompanySkill
{
    public class DeleteCompanySkillDTOValidation : DeleteValidation<DeleteCompanySkillDTO>
    {
        public DeleteCompanySkillDTOValidation() : base()
        {
            
        }
    }
}
