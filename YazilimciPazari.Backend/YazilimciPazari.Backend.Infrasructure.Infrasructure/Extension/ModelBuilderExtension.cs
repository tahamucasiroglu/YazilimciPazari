﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace YazilimciPazari.Backend.Infrasructure.Infrasructure.Extension
{
    static public class ModelBuilderExtension
    {
        static public ModelBuilder UseTurkishSqlServer(this ModelBuilder builder) => builder.UseCollation("Turkish_CS_AS");
        static public ModelBuilder UseTurkishPostgreSql(this ModelBuilder builder) => builder.UseCollation("Turkish_Turkey.1254");
        static public ModelBuilder GetAllConfigsAuto(this ModelBuilder builder) => builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        static public ModelBuilder SetSchema(this ModelBuilder builder) => builder.HasDefaultSchema("Okusana");
    }
}
