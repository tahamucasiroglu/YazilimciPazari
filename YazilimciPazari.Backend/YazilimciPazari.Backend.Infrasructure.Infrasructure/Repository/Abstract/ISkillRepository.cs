using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract.Base;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract
{
    public interface ISkillRepository : IRepository<Skill>
    {
    }
}
