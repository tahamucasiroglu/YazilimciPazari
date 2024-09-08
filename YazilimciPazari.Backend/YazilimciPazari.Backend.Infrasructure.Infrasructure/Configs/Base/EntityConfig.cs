using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YazilimciPazari.Backend.Domain.Entities.Abstract;
using YazilimciPazari.Backend.Domain.Entities.Base;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Configs.Base
{
    public class EntityConfig : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.IsDeleted);
            builder.UseTpcMappingStrategy();
            builder.HasQueryFilter(e => !e.IsDeleted);
        }
    }
}
