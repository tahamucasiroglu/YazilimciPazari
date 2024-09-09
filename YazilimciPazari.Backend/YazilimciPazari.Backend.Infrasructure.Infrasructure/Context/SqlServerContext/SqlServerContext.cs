using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.Base;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Extension;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.SqlServerContext
{
    public class SqlServerContext : BaseContext
    {
        public SqlServerContext() { }
        public SqlServerContext(DbContextOptions<BaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseTurkishSqlServer();
            base.OnModelCreating(modelBuilder);
        }
    }
}
