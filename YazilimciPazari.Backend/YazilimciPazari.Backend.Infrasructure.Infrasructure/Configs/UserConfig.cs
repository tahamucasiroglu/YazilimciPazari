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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(5000).IsRequired();
            builder.Property(e => e.IdentityNumber).HasMaxLength(128).IsRequired();
            builder.Property(e => e.Password).HasMaxLength(128).IsRequired();
            builder.Property(e => e.Address).HasMaxLength(500).IsRequired();
            builder.Property(e => e.Website).HasMaxLength(500).IsRequired();
        }
    }
}
