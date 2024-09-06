using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.UserSkill;

namespace YazilimciPazari.Backend.Application.Validation.Validation.UserSkill
{
    public class DeleteUserSkillDTOValidation : DeleteValidation<DeleteUserSkillDTO>
    {
        public DeleteUserSkillDTOValidation() : base()
        { 
        }
    }
}
