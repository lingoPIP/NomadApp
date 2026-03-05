
using Microsoft.AspNetCore.Identity;

namespace NomadApp.Data.Models
{
    public  class ApplicationUser:IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
        }
    }
}
