﻿namespace YazilimciPazari.Backend.Presentation.API.Extension
{
    static public class LoggerServiceExtension
    {
        static public void SetMinLevelToWarning(this ILoggingBuilder builder) => builder.SetMinimumLevel(LogLevel.Warning);
        static public void AddLoggerToService(this IServiceCollection services) => services.AddLogging(c => c.SetMinLevelToWarning());
    }
}
