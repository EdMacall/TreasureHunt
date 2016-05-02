using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace TreasureHunt.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TeamClue>().HasKey(x => new { x.TeamId, x.ClueId });
            builder.Entity<TeamUser>().HasKey(x => new { x.TeamId, x.ApplicationUserId });
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Clue> Clues { get; set; }
        public DbSet<Hunt> Hunts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamClue> TeamClues { get; set; }
        public DbSet<TeamUser> TeamUsers { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    }
}
