using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.CompanyComment;
using YazilimciPazari.Backend.Presentation.API.Controllers.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyCommentController : Controller<GetCompanyCommentDTO, AddCompanyCommentDTO, UpdateCompanyCommentDTO, DeleteCompanyCommentDTO>
    {
        public CompanyCommentController(ICompanyCommentService service) : base(service) { }
    }
}
