using Microsoft.EntityFrameworkCore;
using Persistence.EntityTypeConfigurations;
using Application.Interfaces;
using Domain.Entities;
using System.Reflection;

namespace Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }


        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base (options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}