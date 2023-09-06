using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Application.Interfaces;



namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString, string authDbConnectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            services.AddScoped<IApplicationDbContext>(provider =>
                provider.GetService<ApplicationDbContext>());



            using (var provider = services.BuildServiceProvider())
            {
                try
                {
                    var context = provider.GetRequiredService<ApplicationDbContext>();
                    DbInitializer.Initialze(context);
                }
                catch 
                { 
                    
                }
            }

            return services;
        }
    }
}