using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NomadApp.Data
{
    public class NomadDbContext : IdentityDbContext
    {
        public NomadDbContext(DbContextOptions<NomadDbContext> options)
            : base(options)
        {
        }
    }
}
