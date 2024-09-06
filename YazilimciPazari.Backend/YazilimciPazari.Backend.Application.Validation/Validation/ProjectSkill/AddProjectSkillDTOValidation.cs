using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.ProjectSkill;

namespace YazilimciPazari.Backend.Application.Validation.Validation.ProjectSkill
{
    public class AddProjectSkillDTOValidation : AddValidation<AddProjectSkillDTO>
    {
        public AddProjectSkillDTOValidation() : base() 
        {
            RuleFor(e => e.UserId).IdValidation();
            RuleFor(e => e.SkillId).IdValidation();
        }
    }
}
