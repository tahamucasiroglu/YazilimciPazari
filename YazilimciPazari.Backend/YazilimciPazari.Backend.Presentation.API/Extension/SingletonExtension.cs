using YazilimciPazari.Backend.Presentation.API.Attributes;

namespace YazilimciPazari.Backend.Presentation.API.Extension
{
    static public class SingletonExtension
    {

        public static void AddSingleton(this WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddSingleton<LogConnectionAttribute>();
        }
    }
}
