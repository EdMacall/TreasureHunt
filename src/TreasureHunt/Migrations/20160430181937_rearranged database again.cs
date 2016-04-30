using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace TreasureHunt.Migrations
{
    public partial class rearrangeddatabaseagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_ApplicationUser_Team_TeamId", table: "AspNetUsers");
            migrationBuilder.DropForeignKey(name: "FK_HuntRiddle_Hunt_HuntId", table: "HuntRiddle");
            migrationBuilder.DropForeignKey(name: "FK_HuntRiddle_Riddle_RiddleId", table: "HuntRiddle");
            migrationBuilder.DropForeignKey(name: "FK_HuntTeam_Hunt_HuntId", table: "HuntTeam");
            migrationBuilder.DropForeignKey(name: "FK_HuntTeam_Team_TeamId", table: "HuntTeam");
            migrationBuilder.DropForeignKey(name: "FK_Riddle_Hunt_HuntId", table: "Riddle");
            migrationBuilder.DropForeignKey(name: "FK_Riddle_Team_TeamId", table: "Riddle");
            migrationBuilder.DropForeignKey(name: "FK_Team_Hunt_HuntId", table: "Team");
            migrationBuilder.DropForeignKey(name: "FK_TeamApplicationUser_Team_TeamId", table: "TeamApplicationUser");
            migrationBuilder.DropForeignKey(name: "FK_TeamRiddle_Riddle_RiddleId", table: "TeamRiddle");
            migrationBuilder.DropForeignKey(name: "FK_TeamRiddle_Team_TeamId", table: "TeamRiddle");
            migrationBuilder.DropColumn(name: "HuntId", table: "Riddle");
            migrationBuilder.DropColumn(name: "TeamId", table: "Riddle");
            migrationBuilder.DropColumn(name: "TeamId", table: "AspNetUsers");
            migrationBuilder.CreateTable(
                name: "Clue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Answer = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    HuntId = table.Column<int>(nullable: false),
                    PointValue = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clue_Hunt_HuntId",
                        column: x => x.HuntId,
                        principalTable: "Hunt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "TeamUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApplicationUserId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamUser_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "ApplicationUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamUser_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "TeamClue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClueId = table.Column<int>(nullable: false),
                    Solved = table.Column<bool>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    TeamsAnswer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamClue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamClue_Clue_ClueId",
                        column: x => x.ClueId,
                        principalTable: "Clue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamClue_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.AlterColumn<int>(
                name: "HuntId",
                table: "Team",
                nullable: false);
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Team",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Hunt",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "ApplicationUserId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddUniqueConstraint(
                name: "AK_ApplicationUser_ApplicationUserId",
                table: "AspNetUsers",
                column: "ApplicationUserId");
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_HuntRiddle_Hunt_HuntId",
                table: "HuntRiddle",
                column: "HuntId",
                principalTable: "Hunt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_HuntRiddle_Riddle_RiddleId",
                table: "HuntRiddle",
                column: "RiddleId",
                principalTable: "Riddle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_HuntTeam_Hunt_HuntId",
                table: "HuntTeam",
                column: "HuntId",
                principalTable: "Hunt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_HuntTeam_Team_TeamId",
                table: "HuntTeam",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Team_Hunt_HuntId",
                table: "Team",
                column: "HuntId",
                principalTable: "Hunt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_TeamApplicationUser_Team_TeamId",
                table: "TeamApplicationUser",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_TeamRiddle_Riddle_RiddleId",
                table: "TeamRiddle",
                column: "RiddleId",
                principalTable: "Riddle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_TeamRiddle_Team_TeamId",
                table: "TeamRiddle",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId", table: "AspNetRoleClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId", table: "AspNetUserClaims");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId", table: "AspNetUserLogins");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_IdentityRole_RoleId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_IdentityUserRole<string>_ApplicationUser_UserId", table: "AspNetUserRoles");
            migrationBuilder.DropForeignKey(name: "FK_HuntRiddle_Hunt_HuntId", table: "HuntRiddle");
            migrationBuilder.DropForeignKey(name: "FK_HuntRiddle_Riddle_RiddleId", table: "HuntRiddle");
            migrationBuilder.DropForeignKey(name: "FK_HuntTeam_Hunt_HuntId", table: "HuntTeam");
            migrationBuilder.DropForeignKey(name: "FK_HuntTeam_Team_TeamId", table: "HuntTeam");
            migrationBuilder.DropForeignKey(name: "FK_Team_Hunt_HuntId", table: "Team");
            migrationBuilder.DropForeignKey(name: "FK_TeamApplicationUser_Team_TeamId", table: "TeamApplicationUser");
            migrationBuilder.DropForeignKey(name: "FK_TeamRiddle_Riddle_RiddleId", table: "TeamRiddle");
            migrationBuilder.DropForeignKey(name: "FK_TeamRiddle_Team_TeamId", table: "TeamRiddle");
            migrationBuilder.DropUniqueConstraint(name: "AK_ApplicationUser_ApplicationUserId", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "ImageURL", table: "Team");
            migrationBuilder.DropColumn(name: "ImageURL", table: "Hunt");
            migrationBuilder.DropColumn(name: "ApplicationUserId", table: "AspNetUsers");
            migrationBuilder.DropColumn(name: "ImageURL", table: "AspNetUsers");
            migrationBuilder.DropTable("TeamClue");
            migrationBuilder.DropTable("TeamUser");
            migrationBuilder.DropTable("Clue");
            migrationBuilder.AlterColumn<int>(
                name: "HuntId",
                table: "Team",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "HuntId",
                table: "Riddle",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Riddle",
                nullable: true);
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "AspNetUsers",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityRoleClaim<string>_IdentityRole_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserClaim<string>_ApplicationUser_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserLogin<string>_ApplicationUser_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_IdentityRole_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUserRole<string>_ApplicationUser_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_Team_TeamId",
                table: "AspNetUsers",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_HuntRiddle_Hunt_HuntId",
                table: "HuntRiddle",
                column: "HuntId",
                principalTable: "Hunt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_HuntRiddle_Riddle_RiddleId",
                table: "HuntRiddle",
                column: "RiddleId",
                principalTable: "Riddle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_HuntTeam_Hunt_HuntId",
                table: "HuntTeam",
                column: "HuntId",
                principalTable: "Hunt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_HuntTeam_Team_TeamId",
                table: "HuntTeam",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Riddle_Hunt_HuntId",
                table: "Riddle",
                column: "HuntId",
                principalTable: "Hunt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Riddle_Team_TeamId",
                table: "Riddle",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Team_Hunt_HuntId",
                table: "Team",
                column: "HuntId",
                principalTable: "Hunt",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_TeamApplicationUser_Team_TeamId",
                table: "TeamApplicationUser",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_TeamRiddle_Riddle_RiddleId",
                table: "TeamRiddle",
                column: "RiddleId",
                principalTable: "Riddle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_TeamRiddle_Team_TeamId",
                table: "TeamRiddle",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
