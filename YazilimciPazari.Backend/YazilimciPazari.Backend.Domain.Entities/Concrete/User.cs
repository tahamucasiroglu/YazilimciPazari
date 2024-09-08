using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Domain.Entities.Concrete
{
    public class User : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string IdentityNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Website { get; set; } = string.Empty;

        virtual public ICollection<Project> Projects { get; set; } = new HashSet<Project>();
        virtual public ICollection<User> Users { get; set; } = new HashSet<User>();
        virtual public ICollection<UserComment> UserComments { get; set; } = new HashSet<UserComment>();
        virtual public ICollection<UserSkill> UserSkills { get; set; } = new HashSet<UserSkill>();
    }
}
