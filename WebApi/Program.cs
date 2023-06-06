using Application;
using Persistence;
using Microsoft.Extensions.Configuration; 

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;

        services.AddApplication();
        services.AddPersistence();
        services.AddControllers();


        var app = builder.Build();

        app.UseRouting();
        app.MapControllers();
        //app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}