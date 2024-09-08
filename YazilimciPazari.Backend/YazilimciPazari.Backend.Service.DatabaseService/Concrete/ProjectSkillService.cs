using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.ProjectSkill;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Base;

namespace YazilimciPazari.Backend.Service.DatabaseService.Concrete
{
    public class ProjectSkillService : Service<ProjectSkill, GetProjectSkillDTO, AddProjectSkillDTO, UpdateProjectSkillDTO>, IProjectSkillService
    {
        public ProjectSkillService(IRepository<ProjectSkill> repository, IMapper mapper, IConfiguration configuration) : base(repository, mapper, configuration)
        {
        }
    }
}
