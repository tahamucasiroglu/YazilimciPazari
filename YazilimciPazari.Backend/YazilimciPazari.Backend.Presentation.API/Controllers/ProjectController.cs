using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Project;
using YazilimciPazari.Backend.Presentation.API.Controllers.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : Controller<GetProjectDTO, AddProjectDTO, UpdateProjectDTO, DeleteProjectDTO>
    {
        public ProjectController(IProjectService service) : base(service) { }
    }
}
