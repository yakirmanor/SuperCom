using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Serilog;

namespace SuperCom.Application.Extensions
{
    public static class LoggingServiceExtensions
    {
        public static void UseLoggingDependencyExtensions(this IServiceCollection services)
        {
            var appsettings = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false).Build();
            var path = appsettings.GetValue<string>("Logging:FilePath");
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File(path, fileSizeLimitBytes: 10 * 1000000).CreateLogger();
            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
            services.AddSingleton(typeof(Microsoft.Extensions.Logging.ILogger), services.BuildServiceProvider().GetService<ILogger<object>>());
        }

        public static void UseServerlessLoggingDependencyExtensions(this IServiceCollection services)
        {
            services.AddSingleton(typeof(Microsoft.Extensions.Logging.ILogger), services.BuildServiceProvider().GetService<ILogger<object>>());
        }
    }
}
