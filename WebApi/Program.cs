using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using Application;
using Persistence;
using Persistence.Identity;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;

        

        services.AddApplication();
        NameValueCollection appSetings = System.Configuration.ConfigurationManager.AppSettings;
        services.AddPersistence(appSetings.Get("PostgresConnectionString"), appSetings.Get(1));

        services.AddAuthentication()
            .AddJwtBearer(options =>
            {
                options.Authority = "https://localhost:5001";

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false
                };
            });

        services.AddControllers();


        var app = builder.Build();
        
        app.UseRouting();
        app.UseHttpsRedirection();
        app.MapControllers();
        app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}