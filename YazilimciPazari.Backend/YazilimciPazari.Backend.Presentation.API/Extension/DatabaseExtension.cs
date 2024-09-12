using Microsoft.EntityFrameworkCore;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.Base;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.PostgreSqlContext;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.SqlServerContext;

namespace YazilimciPazari.Backend.Presentation.API.Extension
{
    static public class DatabaseExtension
    {

        static public void AddDatabase(this WebApplicationBuilder builder)
        {
            string? provider = builder.Configuration.GetValue<string>("DatabaseProvider");
            switch (provider)
            {
                case "SqlServer":
                    builder.AddSqlServer();
                    break;

                case "PostgreSql":
                    builder.AddPostgreSql();
                    break;
            }
        }

        static public async Task RestartDatabase(this WebApplication builder)
        {
            string? provider = builder.Configuration.GetValue<string>("DatabaseProvider");

            using (var scope = builder.Services.CreateScope())
            {
                switch (provider)
                {
                    case "SqlServer":
                        var sqlContext = scope.ServiceProvider.GetRequiredService<SqlServerContext>();
                        await builder.Restart(sqlContext);
                        break;

                    case "PostgreSql":
                        var pgContext = scope.ServiceProvider.GetRequiredService<PostgreSqlContext>();
                        await builder.Restart(pgContext);
                        break;
                }
            }
        }


        static private async Task Restart(this WebApplication builder, BaseContext context)
        {

            if (context.Database.CanConnect())
            {
                Console.WriteLine("Database Siliniyor");
                await context.Database.EnsureDeletedAsync();
                Console.WriteLine("Database Slindi");
                Console.WriteLine("Database Üretiliyor");
                await context.Database.EnsureCreatedAsync();
                Console.WriteLine("Database Üretildi");
            }
            else
            {
                Console.WriteLine("\n\n Restart için veritabanına bağlanamadı \n\n");
            }
            
        }


        static public void AddSqlServer(this WebApplicationBuilder builder, bool restart = true)
        {
            string? connectionString = builder.Configuration.GetConnectionString("SqlServerString");
            builder.Services.AddDbContext<BaseContext, SqlServerContext>(opt =>
            {
                opt.UseSqlServer(connectionString);
                opt.UseLoggerFactory(LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                    builder.SetMinimumLevel(LogLevel.Warning); //açılıştaki bir sürü konsol çıktısını önlemek için
                }));
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
        }

        public static void AddPostgreSql(this WebApplicationBuilder builder)
        {
            string? connectionString = builder.Configuration.GetConnectionString("PostgreSqlString");
            builder.Services.AddDbContext<BaseContext, PostgreSqlContext>(opt =>
            {
                opt.UseNpgsql(connectionString);
                opt.UseLoggerFactory(LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                    builder.SetMinimumLevel(LogLevel.Warning);
                }));
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
        }
    }
}
