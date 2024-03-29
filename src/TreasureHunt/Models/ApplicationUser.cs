using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TreasureHunt.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // Inherits Id,  UserName,  EmailAddress,  and  Password
        public string ImageURL { get; set; }

        public ICollection<TeamUser> TeamUsers { get; set; }
    }
}
