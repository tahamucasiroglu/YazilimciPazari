using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context;

namespace YazilimciPazari.Backend.Presentation.API.Extension
{
    static public class DatabaseExtension
    {

        static public void AddDatabase(this WebApplicationBuilder builder)
        {
            string? connectionString = builder.Configuration.GetConnectionString("SqlServerString");
            builder.Services.AddDbContext<SqlServerContext>(opt =>
            {
                opt.UseSqlServer(connectionString);
                opt.UseLoggerFactory(LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                    builder.SetMinimumLevel(LogLevel.Warning); //açılıştaki bir sürü konsol çıktısını önlemek için
                }));
                opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
            Console.WriteLine("Db eklendi");
        }

        static public async Task RestartDatabase(this WebApplication builder)
        {
            var sqlContext = builder.Services.CreateScope().ServiceProvider.GetRequiredService<SqlServerContext>();
            if (sqlContext.Database.CanConnect())
            {
                Console.WriteLine("Database Siliniyor");
                await sqlContext.Database.EnsureDeletedAsync();
                Console.WriteLine("Database Slindi");
                Console.WriteLine("Database Üretiliyor");
                await sqlContext.Database.EnsureCreatedAsync();
                Console.WriteLine("Database Üretildi");
            }
            else
            {
                Console.WriteLine("\n\n Restart için veritabanına bağlanamadı \n\n");
            }
        }
    }
}
