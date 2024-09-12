using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using YazilimciPazari.Backend.Application.Mapper.MapProfile;
using YazilimciPazari.Backend.Domain.Entities.Concrete;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.Base;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.PostgreSqlContext;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.SqlServerContext;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract.Base;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Base;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Concrete;
using YazilimciPazari.Backend.Presentation.API.Extension;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Concrete;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddLogging(logging =>
        {
            logging.AddConfiguration(builder.Configuration.GetSection("Logging"));
            logging.AddConsole();
        });

        // Add services to the container.
        //builder.AddDatabase();

        string? databaseProvider = builder.Configuration.GetValue<string>("DatabaseProvider");
        switch (databaseProvider)
        {
            case "SqlServer":
                builder.Services.AddDbContext<BaseContext, SqlServerContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerString")));
                break;
            case "PostgreSql":
                builder.Services.AddDbContext<BaseContext, PostgreSqlContext>(options =>
                    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlString")));
                break;
            default:
                throw new Exception("Unknown database provider");
        }


        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        //builder.Services.AddScoped<IRepository<Comment>, Repository<Comment>>();
        //builder.Services.AddScoped<IRepository<CompanyComment>, Repository<CompanyComment>>();
        //builder.Services.AddScoped<IRepository<Company>, Repository<Company>>();
        //builder.Services.AddScoped<IRepository<CompanySkill>, Repository<CompanySkill>>();
        //builder.Services.AddScoped<IRepository<Project>, Repository<Project>>();
        //builder.Services.AddScoped<IRepository<ProjectSkill>, Repository<ProjectSkill>>();
        //builder.Services.AddScoped<IRepository<Skill>, Repository<Skill>>();
        //builder.Services.AddScoped<IRepository<UserComment>, Repository<UserComment>>();
        //builder.Services.AddScoped<IRepository<User>, Repository<User>>();
        //builder.Services.AddScoped<IRepository<UserSkill>, Repository<UserSkill>>();

        builder.Services.AddScoped<ICommentRepository, CommentRepository>();
        builder.Services.AddScoped<ICompanyCommentRepository, CompanyCommentRepository>();
        builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
        builder.Services.AddScoped<ICompanySkillRepository, CompanySkillRepository>();
        builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
        builder.Services.AddScoped<IProjectSkillRepository, ProjectSkillRepository>();
        builder.Services.AddScoped<ISkillRepository, SkillRepository>();
        builder.Services.AddScoped<IUserCommentRepository, UserCommentRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IUserSkillRepository, UserSkillRepository>();




        builder.Services.AddScoped<ICommentService, CommentService>();
        builder.Services.AddScoped<ICompanyCommentService, CompanyCommentService>();
        builder.Services.AddScoped<ICompanyService, CompanyService>();
        builder.Services.AddScoped<ICompanySkillService, CompanySkillService>();
        builder.Services.AddScoped<IProjectService, ProjectService>();
        builder.Services.AddScoped<IProjectSkillService, ProjectSkillService>();
        builder.Services.AddScoped<ISkillService, SkillService>();
        builder.Services.AddScoped<IUserCommentService, UserCommentService>();
        builder.Services.AddScoped<IUserService, UserService>();
        builder.Services.AddScoped<IUserSkillService, UserSkillService>();



        builder.Services.AddAutoMapper(typeof(MapProfile));
        IEnumerable<Type> validatorTypes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => !t.IsAbstract &&
                        t.BaseType != null &&
                        t.BaseType.IsGenericType &&
                        t.BaseType.GetGenericTypeDefinition() == typeof(AbstractValidator<>));

        foreach (Type validatorType in validatorTypes)
        {
            // Validator sýnýfýnýn generic türünü bul ve DI'ya ekle
            Type? genericType = validatorType.BaseType?.GetGenericArguments().FirstOrDefault();
            if (genericType != null)
            {
                builder.Services.AddTransient(typeof(IValidator<>).MakeGenericType(genericType), validatorType);
            }
        }
        builder.Services.AddHttpContextAccessor();



        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // For Test
        builder.Logging.AddConsole();
        builder.Logging.SetMinimumLevel(LogLevel.Debug);


        var app = builder.Build();

        app.UsePathBase("/");

        await app.RestartDatabase(); //Extension

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors("Any");

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}