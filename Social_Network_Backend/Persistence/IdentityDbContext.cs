using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Persistence.Identity;

namespace Persistence
{
    public class IdentityDbContext : IdentityDbContext<ApplicationUser, IdentityRole<long>,  long>
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options) : base (options) 
        {
            Database.Migrate();
        } 
    }
}