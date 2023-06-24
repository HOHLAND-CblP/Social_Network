using Microsoft.EntityFrameworkCore;
using Persistence.EntityTypeConfigurations;
using Application.Interfaces;
using Domain.Entities;

namespace Persistence
{
    public class UsersDbContext : DbContext, IUsersDbContext
    {
        public DbSet<User>  Users { get; set; }


        public UsersDbContext (DbContextOptions<UsersDbContext> options)
            : base (options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(builder);
        }
    }
}