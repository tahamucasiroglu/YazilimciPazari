using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.UserComment;
using YazilimciPazari.Backend.Presentation.API.Controllers.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCommentController : Controller<GetUserCommentDTO, AddUserCommentDTO, UpdateUserCommentDTO, DeleteUserCommentDTO>
    {
        public UserCommentController(IUserCommentService service) : base(service) { }
    }
}
