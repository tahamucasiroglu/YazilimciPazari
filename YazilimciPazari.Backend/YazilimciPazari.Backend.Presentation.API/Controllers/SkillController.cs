using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Skill;
using YazilimciPazari.Backend.Presentation.API.Controllers.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : Controller<GetSkillDTO, AddSkillDTO, UpdateSkillDTO, DeleteSkillDTO>
    {
        public SkillController(ISkillService service) : base(service) { }
    }
}
