using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Comment;
using YazilimciPazari.Backend.Presentation.API.Attributes;
using YazilimciPazari.Backend.Presentation.API.Controllers.Base;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract.Base;

namespace YazilimciPazari.Backend.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : Controller<GetCommentDTO, AddCommentDTO, UpdateCommentDTO, DeleteCommentDTO>
    {
       
        public CommentController(ICommentService service) : base(service) 
        {
               
        }



    }
}
