using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Company;
using YazilimciPazari.Backend.Presentation.API.Controllers.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : Controller<GetCompanyDTO, AddCompanyDTO, UpdateCompanyDTO, DeleteCompanyDTO>
    {
        public CompanyController(ICompanyService service) : base(service) { }
    }
}
