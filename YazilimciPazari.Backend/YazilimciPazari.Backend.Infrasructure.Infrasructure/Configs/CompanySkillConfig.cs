using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Concrete;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Configs
{
    public class CompanySkillConfig : IEntityTypeConfiguration<CompanySkill>
    {
        public void Configure(EntityTypeBuilder<CompanySkill> builder)
        {
            builder.HasIndex(e => new { e.SkillId, e.CompanyId });

            builder.Property(e => e.SkillId).IsRequired();
            builder.Property(e => e.CompanyId).IsRequired();

            builder.HasOne(e => e.Skill)
                .WithMany(e => e.CompanySkills)
                .HasForeignKey(e => e.SkillId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_CompanySkill_Skill");

            builder.HasOne(e => e.Company)
                .WithMany(e => e.CompanySkills)
                .HasForeignKey(e => e.CompanyId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_CompanySkill_Company");
        }
    }
}
