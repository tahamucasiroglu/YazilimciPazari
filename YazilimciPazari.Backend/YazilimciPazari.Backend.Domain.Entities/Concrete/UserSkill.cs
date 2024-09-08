using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Domain.Entities.Concrete
{
    public class UserSkill : Entity
    {
        public Guid UserId { get; set; }
        public Guid SkillId { get; set; }

        virtual public User User { get; set; } = new();
        virtual public Skill Skill { get; set; } = new();
    }
}
