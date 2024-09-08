using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Base;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Concrete
{
    public class ProjectSkillRepository<TContext> : Repository<ProjectSkill, TContext>
        where TContext : DbContext, new()
    {
        public ProjectSkillRepository(TContext context) : base(context) { }
    }
}
