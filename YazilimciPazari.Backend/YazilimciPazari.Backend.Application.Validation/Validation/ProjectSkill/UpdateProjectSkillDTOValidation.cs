using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.ProjectSkill;

namespace YazilimciPazari.Backend.Application.Validation.Validation.ProjectSkill
{
    public class UpdateProjectSkillDTOValidation : UpdateValidation<UpdateProjectSkillDTO>
    {
        public UpdateProjectSkillDTOValidation() : base()
        {
            
        }
    }
}
