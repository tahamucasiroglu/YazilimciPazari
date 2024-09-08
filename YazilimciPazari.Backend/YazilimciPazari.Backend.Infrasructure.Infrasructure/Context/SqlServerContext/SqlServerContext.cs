using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Extension;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.SqlServerContext
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext() { }
        public SqlServerContext(DbContextOptions options) : base(options) { }

        virtual public DbSet<Comment> Comments { get; set; }
        virtual public DbSet<CompanyComment> CompanyComments { get; set; }
        virtual public DbSet<Company> Companies { get; set; }
        virtual public DbSet<CompanySkill> CompanySkills { get; set; }
        virtual public DbSet<Project> Projects { get; set; }
        virtual public DbSet<ProjectSkill> ProjectSkills { get; set; }
        virtual public DbSet<Skill> Skills { get; set; }
        virtual public DbSet<UserComment> UserComments { get; set; }
        virtual public DbSet<User> Users { get; set; }
        virtual public DbSet<UserSkill> UserSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseTurkishSqlServer();
            modelBuilder.GetAllConfigsAuto();
            modelBuilder.SetSchema();
            base.OnModelCreating(modelBuilder);
        }
    }
}
