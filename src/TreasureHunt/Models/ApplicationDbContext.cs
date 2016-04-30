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
            // builder.Entity<TeamUser>().HasKey(x => new { x.TeamId, x.ApplicationUserId });
            // builder.Entity<TeamClue>().HasKey(x => new { x.TeamId, x.ClueId });

            // phasing these tables out...
            builder.Entity<HuntTeam>().HasKey(x => new { x.HuntId, x.TeamId });
            builder.Entity<HuntRiddle>().HasKey(x => new { x.HuntId, x.RiddleId });
            builder.Entity<TeamRiddle>().HasKey(x => new { x.TeamId, x.RiddleId });
            builder.Entity<TeamApplicationUser>().HasKey(x => new { x.TeamId, x.ApplicationUserId });
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Hunt> Hunts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamUser> TeamUsers { get; set; }
        public DbSet<Clue> Clues { get; set; }
        public DbSet<TeamClue> TeamClues { get; set; }

        // phasing these tables out...
        public DbSet<Riddle> Riddles { get; set; }
        public DbSet<HuntTeam> HuntTeams { get; set; }
        public DbSet<HuntRiddle> HuntRiddles { get; set; }
        public DbSet<TeamRiddle> TeamRiddles { get; set; }
        public DbSet<TeamApplicationUser> TeamApplicationUsers { get; set; }
    }
}
