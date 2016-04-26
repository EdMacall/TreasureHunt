using System;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class SampleData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            context.Database.Migrate();

            // Ensure Stephen (IsAdmin)
            var stephen = await userManager.FindByNameAsync("Stephen.Walther@CoderCamps.com");
            if (stephen == null)
            {
                // create user
                stephen = new ApplicationUser
                {
                    UserName = "Stephen.Walther@CoderCamps.com",
                    Email = "Stephen.Walther@CoderCamps.com"
                };
                await userManager.CreateAsync(stephen, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(stephen, new Claim("IsAdmin", "true"));
            }

            // Ensure irvedwmac (IsAdmin)
            var irvedwmac = await userManager.FindByNameAsync("irvedwmac@aol.com");
            if (irvedwmac == null)
            {
                // create user
                irvedwmac = new ApplicationUser
                {
                    UserName = "irvedwmac@aol.com",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(irvedwmac, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(irvedwmac, new Claim("IsAdmin", "true"));
            }

            // Ensure xayadeth (IsAdmin)
            var xayadeth = await userManager.FindByNameAsync("xayadeth360@gmail.com");
            if (xayadeth == null)
            {
                // create user
                xayadeth = new ApplicationUser
                {
                    UserName = "xayadeth360@gmail.com",
                    Email = "xayadeth360@gmail.com"
                };
                await userManager.CreateAsync(xayadeth, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(xayadeth, new Claim("IsAdmin", "true"));
            }

            // Ensure gescobedoz (IsAdmin)
            var gescobedoz = await userManager.FindByNameAsync("gescobedoz@broncs.utpa.edu");
            if (gescobedoz == null)
            {
                // create user
                gescobedoz = new ApplicationUser
                {
                    UserName = "gescobedoz@broncs.utpa.edu",
                    Email = "gescobedoz@broncs.utpa.edu"
                };
                await userManager.CreateAsync(gescobedoz, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(gescobedoz, new Claim("IsAdmin", "true"));
            }

            // Ensure Mike (not IsAdmin)
            var mike = await userManager.FindByNameAsync("Mike@CoderCamps.com");
            if (mike == null)
            {
                // create user
                mike = new ApplicationUser
                {
                    UserName = "Mike@CoderCamps.com",
                    Email = "Mike@CoderCamps.com"
                };
                await userManager.CreateAsync(mike, "Secret123!");
            }


        }

    }
}
