﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Application.Validation.Extension;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.UserSkill;

namespace YazilimciPazari.Backend.Application.Validation.Validation.UserSkill
{
    public class AddUserSkillDTOValidation : AddValidation<AddUserSkillDTO>
    {
        public AddUserSkillDTOValidation() : base() 
        {
            RuleFor(e => e.UserId).IdValidation();
            RuleFor(e => e.SkillId).IdValidation();
        }
    }
}