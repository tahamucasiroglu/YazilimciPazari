using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Domain.Entities.Concrete
{
    public class Company : Entity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public string Password {  get; set; } = string.Empty;
        public string Address {  get; set; } = string.Empty;
        public string Website {  get; set; } = string.Empty;

        virtual public ICollection<CompanyComment> CompanyComments { get; set; } = new HashSet<CompanyComment>();
        virtual public ICollection<CompanySkill> CompanySkills { get; set; } = new HashSet<CompanySkill>();
    }
}
