using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanySkill;

namespace YazilimciPazari.Backend.Application.Validation.Validation.CompanySkill
{
    public class AddCompanySkillDTOValidation : AddValidation<AddCompanySkillDTO>
    {
        public AddCompanySkillDTOValidation() : base()
        {
            RuleFor(e => e.UserId).IdValidation();
            RuleFor(e => e.SkillId).IdValidation();
        }
    }
}
