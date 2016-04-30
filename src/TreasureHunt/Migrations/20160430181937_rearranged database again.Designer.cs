using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using TreasureHunt.Models;

namespace TreasureHunt.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160430181937_rearranged database again")]
    partial class rearrangeddatabaseagain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("TreasureHunt.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("ApplicationUserId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("ImageURL");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("TreasureHunt.Models.Clue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("Description");

                    b.Property<int>("HuntId");

                    b.Property<int>("PointValue");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TreasureHunt.Models.Hunt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name");

                    b.Property<string>("Story");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TreasureHunt.Models.HuntRiddle", b =>
                {
                    b.Property<int>("HuntId");

                    b.Property<int>("RiddleId");

                    b.HasKey("HuntId", "RiddleId");
                });

            modelBuilder.Entity("TreasureHunt.Models.HuntTeam", b =>
                {
                    b.Property<int>("HuntId");

                    b.Property<int>("TeamId");

                    b.HasKey("HuntId", "TeamId");
                });

            modelBuilder.Entity("TreasureHunt.Models.Riddle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<string>("Clue");

                    b.Property<bool>("IsAnswered");

                    b.Property<string>("PlayersAnswer");

                    b.Property<int>("Points");

                    b.Property<string>("Title");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TreasureHunt.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HuntId");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Name");

                    b.Property<int>("Points");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TreasureHunt.Models.TeamApplicationUser", b =>
                {
                    b.Property<int>("TeamId");

                    b.Property<int>("ApplicationUserId");

                    b.Property<string>("ApplicationUserId1");

                    b.HasKey("TeamId", "ApplicationUserId");
                });

            modelBuilder.Entity("TreasureHunt.Models.TeamClue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClueId");

                    b.Property<bool>("Solved");

                    b.Property<int>("TeamId");

                    b.Property<string>("TeamsAnswer");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("TreasureHunt.Models.TeamRiddle", b =>
                {
                    b.Property<int>("TeamId");

                    b.Property<int>("RiddleId");

                    b.HasKey("TeamId", "RiddleId");
                });

            modelBuilder.Entity("TreasureHunt.Models.TeamUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationUserId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TreasureHunt.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TreasureHunt.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("TreasureHunt.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("TreasureHunt.Models.Clue", b =>
                {
                    b.HasOne("TreasureHunt.Models.Hunt")
                        .WithMany()
                        .HasForeignKey("HuntId");
                });

            modelBuilder.Entity("TreasureHunt.Models.HuntRiddle", b =>
                {
                    b.HasOne("TreasureHunt.Models.Hunt")
                        .WithMany()
                        .HasForeignKey("HuntId");

                    b.HasOne("TreasureHunt.Models.Riddle")
                        .WithMany()
                        .HasForeignKey("RiddleId");
                });

            modelBuilder.Entity("TreasureHunt.Models.HuntTeam", b =>
                {
                    b.HasOne("TreasureHunt.Models.Hunt")
                        .WithMany()
                        .HasForeignKey("HuntId");

                    b.HasOne("TreasureHunt.Models.Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("TreasureHunt.Models.Team", b =>
                {
                    b.HasOne("TreasureHunt.Models.Hunt")
                        .WithMany()
                        .HasForeignKey("HuntId");
                });

            modelBuilder.Entity("TreasureHunt.Models.TeamApplicationUser", b =>
                {
                    b.HasOne("TreasureHunt.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId1");

                    b.HasOne("TreasureHunt.Models.Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("TreasureHunt.Models.TeamClue", b =>
                {
                    b.HasOne("TreasureHunt.Models.Clue")
                        .WithMany()
                        .HasForeignKey("ClueId");

                    b.HasOne("TreasureHunt.Models.Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("TreasureHunt.Models.TeamRiddle", b =>
                {
                    b.HasOne("TreasureHunt.Models.Riddle")
                        .WithMany()
                        .HasForeignKey("RiddleId");

                    b.HasOne("TreasureHunt.Models.Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("TreasureHunt.Models.TeamUser", b =>
                {
                    b.HasOne("TreasureHunt.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .HasPrincipalKey("ApplicationUserId");

                    b.HasOne("TreasureHunt.Models.Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });
        }
    }
}
