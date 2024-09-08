using Microsoft.EntityFrameworkCore;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Base;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Concrete
{
    public class CompanyCommentRepository<TContext> : Repository<CompanyComment, TContext>
        where TContext : DbContext, new()
    {
        public CompanyCommentRepository(TContext context) : base(context) { }
    }
}
