using Microsoft.Extensions.Configuration;

var cfg = InitOptions<AppConfig>();

var cs = cfg.ConnectionString;
Console.WriteLine(cs);

var host = cfg.Smtp.Host;
Console.WriteLine(host);

static T InitOptions<T>()
    where T : new()
{
    var config = InitConfig();
    return config.Get<T>();
}

static IConfigurationRoot InitConfig()
{
    var builder = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", true, true);

    return builder.Build();
}