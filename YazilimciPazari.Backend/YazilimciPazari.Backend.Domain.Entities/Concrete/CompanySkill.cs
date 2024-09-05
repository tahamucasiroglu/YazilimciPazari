using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Domain.Entities.Concrete
{
    public class CompanySkill : Entity
    {
        public Guid CompanyId { get; set; }
        public Guid SkillId { get; set; }
    }
}
