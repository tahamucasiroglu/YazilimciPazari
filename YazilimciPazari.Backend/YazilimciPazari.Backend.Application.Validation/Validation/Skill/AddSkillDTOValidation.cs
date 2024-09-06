using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Skill;

namespace YazilimciPazari.Backend.Application.Validation.Validation.Skill
{
    public class AddSkillDTOValidation : AddValidation<AddSkillDTO>
    {
        public AddSkillDTOValidation() : base() 
        {
            RuleFor(e => e.Name).AddNameValidation(maxLength: 100);
        }
    }
}
