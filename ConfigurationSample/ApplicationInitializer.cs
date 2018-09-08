using ConfigurationSample.Interfaces;
using ConfigurationSample.Settings;
using Microsoft.Extensions.Options;

namespace ConfigurationSample
{
    public class ApplicationInitializer : IApplicationInitializer
    {
        private readonly ApplicationSettings _settings;
        public ApplicationInitializer(IOptions<ApplicationSettings> options)
        {
            _settings = options.Value;
        }
        public bool ShowGreetings => _settings.ShowGreetings;

        public bool ShowMotd => _settings.ShowMotd;
    }
}