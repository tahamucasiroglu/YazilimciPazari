using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.UserSkill;
using YazilimciPazari.Backend.Presentation.API.Controllers.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSkillController : Controller<GetUserSkillDTO, AddUserSkillDTO, UpdateUserSkillDTO, DeleteUserSkillDTO>
    {
        public UserSkillController(IUserSkillService service) : base(service) { }   
    }
}
