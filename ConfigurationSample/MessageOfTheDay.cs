using ConfigurationSample.Settings;
using Microsoft.Extensions.Options;

namespace ConfigurationSample
{
    public class MessageOfTheDay
    {
        private readonly MessageOfTheDaySettings _settings;

        public MessageOfTheDay(IOptions<MessageOfTheDaySettings> options)
        {
            _settings = options.Value;
        }

        public string Content => _settings.Content;
        public string Author => _settings.Author;
    }
}