using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", true, true);

var config = builder.Build();

var appName = config["ConnectionString"];
Console.WriteLine(appName);

var rmqHost = config["MassTransit:Host"];
Console.WriteLine(rmqHost);

var cfg = config.Get<AppConfig>();

var cs = cfg.ConnectionString;
Console.WriteLine(cs);

var host = cfg.Smtp.Host;
Console.WriteLine(host);

public class AppConfig
{
    public SmtpOptions Smtp { get; set; }
    public MassTransitOptions MassTransit { get; set; }
    public string ConnectionString { get; set; }
}

public class SmtpOptions
{
    public string Host { get; set; }
    public string From { get; set; }
    public int  Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}

public class MassTransitOptions
{
    public string Host { get; set; }
    public string Queue { get; set; }
}