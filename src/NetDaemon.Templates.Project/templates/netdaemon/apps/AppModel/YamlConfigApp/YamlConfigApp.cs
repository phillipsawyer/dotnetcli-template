namespace AppModel;
/// <summary>
///     Showcases how to instance apps with yaml and use automatic configuration population
///     For advanced configuration options see 
///     https://netdaemon.xyz/docs/app_model/app_model_advanced_config
/// </summary>
[NetDaemonApp]
public class HelloYamlApp
{
    // This will be populated from the yaml with same name


    public HelloYamlApp(IHaContext ha, IAppConfig<HelloConfig> config)
    {
        ha.CallService("notify", "persistent_notification", data: new { message = config.Value.HelloMessage, title = "Hello yaml app!" });
    }
}

public class HelloConfig
{
    public string? HelloMessage { get; set; }
}