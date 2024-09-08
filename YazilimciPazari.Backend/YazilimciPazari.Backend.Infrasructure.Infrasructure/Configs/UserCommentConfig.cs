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
    public class UserCommentConfig : IEntityTypeConfiguration<UserComment>
    {
        public void Configure(EntityTypeBuilder<UserComment> builder)
        {
            builder.HasIndex(e => new { e.CommentId, e.UserId });

            builder.Property(e => e.CommentId).IsRequired();
            builder.Property(e => e.UserId).IsRequired();

            builder.HasOne(e => e.Comment)
                .WithMany(e => e.UserComments)
                .HasForeignKey(e => e.CommentId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_UserComment_Comment");

            builder.HasOne(e => e.User)
                .WithMany(e => e.UserComments)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_UserComment_User");
        }
    }
}
