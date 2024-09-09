using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.Base;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Context.SqlServerContext;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Abstract;
using YazilimciPazari.Backend.Infrasructure.Infrasructure.Repository.Concrete;
using YazilimciPazari.Backend.Service.DatabaseService.Abstract;
using YazilimciPazari.Backend.Service.DatabaseService.Concrete;

namespace YazilimciPazari.Backend.Presentation.API.Extension
{
    static public class ScopedExtension
    {
        public static void AddScoped(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ICommentRepository, CommentRepository<BaseContext>>();
            builder.Services.AddScoped<ICompanyCommentRepository, CompanyCommentRepository<BaseContext>>();
            builder.Services.AddScoped<ICompanyRepository, CompanyRepository<BaseContext>>();
            builder.Services.AddScoped<ICompanySkillRepository, CompanySkillRepository<BaseContext>>();
            builder.Services.AddScoped<IProjectRepository, ProjectRepository<BaseContext>>();
            builder.Services.AddScoped<IProjectSkillRepository, ProjectSkillRepository<BaseContext>>();
            builder.Services.AddScoped<ISkillRepository, SkillRepository<BaseContext>>();
            builder.Services.AddScoped<IUserCommentRepository, UserCommentRepository<BaseContext>>();
            builder.Services.AddScoped<IUserRepository, UserRepository<BaseContext>>();
            builder.Services.AddScoped<IUserSkillRepository, UserSkillRepository<BaseContext>>();




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


        }
    }
}
