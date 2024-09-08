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
    public class ProjectSkillConfig : IEntityTypeConfiguration<ProjectSkill>
    {
        public void Configure(EntityTypeBuilder<ProjectSkill> builder)
        {
            builder.HasIndex(e => new { e.ProjectId, e.SkillId });

            builder.Property(e => e.ProjectId).IsRequired();
            builder.Property(e => e.SkillId).IsRequired();

            builder.HasOne(e => e.Project)
                .WithMany(e => e.ProjectSkills)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_ProjectSkill_Project");

            builder.HasOne(e => e.Skill)
                .WithMany(e => e.ProjectSkills)
                .HasForeignKey(e => e.SkillId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_ProjectSkill_Skill");
        }
    }
}
