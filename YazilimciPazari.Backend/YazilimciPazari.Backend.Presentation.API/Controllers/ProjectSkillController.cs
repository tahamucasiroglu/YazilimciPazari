using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.ProjectSkill;
using YazilimciPazari.Backend.Presentation.API.Controllers.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectSkillController : Controller<GetProjectSkillDTO, AddProjectSkillDTO, UpdateProjectSkillDTO, DeleteProjectSkillDTO>
    {
        public ProjectSkillController(IProjectSkillService service) : base(service) { }
    }
}
