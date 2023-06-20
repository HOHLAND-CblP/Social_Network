using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace Persistence.EntityTypeConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            /*builder.HasKey(user => user.Id);
            builder.HasIndex(user => user.User_Name).IsUnique();*/
            builder.Property(user => user.First_Name).HasDefaultValue();
            builder.Property(user => user.Avatar_Url).HasDefaultValue();
        }
    }
} 