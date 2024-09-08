using Microsoft.EntityFrameworkCore;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Base;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Concrete
{
    public class CompanyRepository<TContext> : Repository<Company, TContext>
        where TContext : DbContext, new()
    {
        public CompanyRepository(TContext context) : base(context) { }
    }
}
