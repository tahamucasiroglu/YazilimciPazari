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
    public class CompanyConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasIndex(e => new { e.TaxNumber, e.Password });

            builder.Property(e => e.Name).IsRequired().HasMaxLength(150);
            builder.Property(e => e.Description).IsRequired().HasMaxLength(10000).HasColumnType("text");
            builder.Property(e => e.TaxNumber).IsRequired().HasMaxLength(150);
            builder.Property(e => e.Password).IsRequired().HasMaxLength(150);
            builder.Property(e => e.Address).IsRequired().HasMaxLength(150);
            builder.Property(e => e.Website).IsRequired().HasMaxLength(150);
        }
    }
}
