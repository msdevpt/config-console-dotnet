public class AppConfig
{
    public SmtpOptions Smtp { get; set; }
    public MassTransitOptions MassTransit { get; set; }
    public string ConnectionString { get; set; }
}
