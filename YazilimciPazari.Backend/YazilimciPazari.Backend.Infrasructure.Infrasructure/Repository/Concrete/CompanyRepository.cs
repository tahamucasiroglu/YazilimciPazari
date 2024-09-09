using Microsoft.EntityFrameworkCore;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Base;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Concrete
{
    public class CompanyRepository<TContext> : Repository<Company, TContext>, ICompanyRepository
        where TContext : DbContext
    {
        public CompanyRepository(TContext context) : base(context) { }
    }
}
