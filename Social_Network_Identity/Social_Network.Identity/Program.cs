using IdentityServer4.Models;

namespace Social_Network.Identity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;

            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                //.AddInMemoryApiResources(new List<ApiResource>())
                //.AddInMemoryIdentityResources(new List<IdentityResource>())
                .AddInMemoryApiScopes(Configuration.ApiScopes)
                .AddInMemoryClients(Configuration.Clients);
                

            var app = builder.Build();

            app.UseRouting();
            app.UseIdentityServer();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}