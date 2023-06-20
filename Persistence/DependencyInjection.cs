using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Application.Interfaces;



namespace Persistence
{
    public static class DependencyInjection
    {
       public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<UsersDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            services.AddScoped<IUsersDbContext>(provider =>
                provider.GetService<UsersDbContext>());
            return services;
        }

        public static IServiceCollection AddPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<UsersDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });
            services.AddScoped<IUsersDbContext>(provider =>
                provider.GetService<UsersDbContext>());
            return services;
        }
    }
}