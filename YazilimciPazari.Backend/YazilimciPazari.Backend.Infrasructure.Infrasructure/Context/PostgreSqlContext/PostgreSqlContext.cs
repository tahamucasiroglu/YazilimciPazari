using Microsoft.EntityFrameworkCore;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.Base;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Extension;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.PostgreSqlContext
{
    public class PostgreSqlContext : BaseContext
    {
        public PostgreSqlContext() { }
        public PostgreSqlContext(DbContextOptions<BaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseTurkishPostgreSql();
            base.OnModelCreating(modelBuilder);
        }
    }
}
