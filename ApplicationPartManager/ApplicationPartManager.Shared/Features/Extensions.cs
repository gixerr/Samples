using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ApplicationPartManager.Shared.Features;

public static class Extensions
{
    public static IHostBuilder ConfigureModules(this IHostBuilder builder)
        => builder.ConfigureAppConfiguration((context, configuration) =>
        {
            foreach (var settings in GetSettings("*"))
            {
                configuration.AddJsonFile(settings);
            }

            foreach (var settings in GetSettings($"*.{context.HostingEnvironment.EnvironmentName}"))
            {
                configuration.AddJsonFile(settings);
            }

            IEnumerable<string> GetSettings(string pattern)
                => Directory.EnumerateFiles(context.HostingEnvironment.ContentRootPath, 
                    $"module.{pattern}.json", SearchOption.AllDirectories);
        });
}