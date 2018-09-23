namespace ConfigurationSample.Interfaces
{
    public interface IApplicationInitializer
    {
         bool ShowGreetings { get; }
         bool ShowMotd { get; }
         bool ShowAbout { get; }
         bool ShowFooter { get; }
    }
}