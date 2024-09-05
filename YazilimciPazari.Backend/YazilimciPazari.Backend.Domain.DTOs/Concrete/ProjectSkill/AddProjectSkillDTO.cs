using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Base;

namespace YazilimciPazari.Backend.Domain.DTOs.Concrete.ProjectSkill
{
    public sealed record AddProjectSkillDTO : AddDTO
    {
        public Guid UserId { get; set; }
        public Guid SkillId { get; set; }
    }
}
