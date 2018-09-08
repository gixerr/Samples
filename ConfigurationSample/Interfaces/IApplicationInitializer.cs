namespace ConfigurationSample.Interfaces
{
    public interface IApplicationInitializer
    {
         bool ShowGreetings { get; }
         bool ShowMotd { get; }
    }
}