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
    public class UserSkillConfig : IEntityTypeConfiguration<UserSkill>
    {
        public void Configure(EntityTypeBuilder<UserSkill> builder)
        {
            builder.HasIndex(e => new { e.UserId, e.SkillId });

            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.SkillId).IsRequired();

            builder.HasOne(e => e.User)
                .WithMany(e => e.UserSkills)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_UserSkill_User");

            builder.HasOne(e => e.Skill)
                .WithMany(e => e.UserSkills)
                .HasForeignKey(e => e.SkillId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_UserSkill_Skill");
        }
    }
}
