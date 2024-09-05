﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Base;

namespace YazilimciPazari.Backend.Domain.DTOs.Concrete.UserSkill
{
    public sealed record AddUserSkillDTO : AddDTO
    {
        public Guid UserId { get; init; }
        public Guid SkillId { get; init; }
    }
}