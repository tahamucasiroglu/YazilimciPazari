using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.ProjectSkill;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract.Base;

namespace YazilimciPazari.Backend.Service.DatabaseService.Abstract
{
    public interface IProjectSkillService : IService<GetProjectSkillDTO, AddProjectSkillDTO, UpdateProjectSkillDTO>
    {
    }
}
