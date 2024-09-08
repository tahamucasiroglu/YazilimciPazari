using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Domain.Entities.Concrete
{
    public class Project : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Guid UserId { get; set; }

        virtual public User User { get; set; } = new();

        virtual public ICollection<ProjectSkill> ProjectSkills { get; set; } = new HashSet<ProjectSkill>();
    }
}
