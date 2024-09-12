using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.DTOs.Concrete.Comment;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract.Base;

namespace YazilimciPazari.Backend.Service.DatabaseService.Abstract
{
    public interface ICommentService : IService<GetCommentDTO, AddCommentDTO, UpdateCommentDTO>
    {
        public GetCommentDTO GetById(Guid Id);
        public Task<GetCommentDTO> GetByIdAsync(Guid Id);


    }
}
