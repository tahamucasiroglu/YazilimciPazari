﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Application.Validation.Base;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Skill;

namespace YazilimciPazari.Backend.Application.Validation.Validation.Skill
{
    public class DeleteSkillDTOValidation : DeleteValidation<DeleteSkillDTO>
    {
        public DeleteSkillDTOValidation() : base() { }
    }
}