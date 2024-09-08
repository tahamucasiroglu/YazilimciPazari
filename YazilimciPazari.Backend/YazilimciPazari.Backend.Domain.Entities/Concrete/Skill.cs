using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Domain.Entities.Concrete
{
    public class Skill : Entity
    {
        public string Name { get; set; } = string.Empty;
        virtual public ICollection<CompanySkill> CompanySkills { get; set; } = new HashSet<CompanySkill>();
        virtual public ICollection<ProjectSkill> ProjectSkills { get; set; } = new HashSet<ProjectSkill>();
        virtual public ICollection<UserSkill> UserSkills { get; set; } = new HashSet<UserSkill>();
    }
}
