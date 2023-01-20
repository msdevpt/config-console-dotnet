using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", true, true);

var config = builder.Build();

var appName = config["ConnectionString"];
Console.WriteLine(appName);

var rmqHost = config["MassTransit:Host"];
Console.WriteLine(rmqHost);