using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanySkill;
using YazilimciPazari.Backend.Presentation.API.Controllers.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanySkillController : Controller<GetCompanySkillDTO, AddCompanySkillDTO, UpdateCompanySkillDTO, DeleteCompanySkillDTO>
    {
        public CompanySkillController(ICompanySkillService service) : base(service) { }
    }
}
