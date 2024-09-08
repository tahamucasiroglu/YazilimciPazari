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
    public class CompanyCommentConfig : IEntityTypeConfiguration<CompanyComment>
    {
        public void Configure(EntityTypeBuilder<CompanyComment> builder)
        {
            builder.HasIndex(e => new{ e.CommentId, e.CompanyId});

            builder.Property(e => e.CommentId).IsRequired();
            builder.Property(e => e.CompanyId).IsRequired();

            builder.HasOne(e => e.Comment)
                .WithMany(e => e.CompanyComments)
                .HasForeignKey(e => e.CommentId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_CompanyComment_Comment");

            builder.HasOne(e => e.Company)
                .WithMany(e => e.CompanyComments)
                .HasForeignKey(e => e.CompanyId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_CompanyComment_Company");






        }
    }
}
