using Application;
using Persistence;
using System.Collections.Specialized;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;

        

        services.AddApplication();
        services.AddPersistence(System.Configuration.ConfigurationManager.AppSettings.Get("PostgresConnectionString"));
        services.AddControllers();


        var app = builder.Build();

        app.UseRouting();
        app.UseHttpsRedirection();
        app.MapControllers();
        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}