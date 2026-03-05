using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NomadApp.Data.Models;

namespace NomadApp.Data
{
    public class NomadDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        // for debugging purposes
        public NomadDbContext()
        {
            
        }
        public NomadDbContext(DbContextOptions<NomadDbContext> options)
            : base(options)
        {
        }
    }
}
