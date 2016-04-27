using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace TreasureHunt.Migrations
{
    public partial class Points : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
            migrationBuilder.DropForeignKey(name: "FK_TeamApplicationUser_Team_TeamId", table: "TeamApplicationUser");
            migrationBuilder.DropForeignKey(name: "FK_TeamRiddle_Riddle_RiddleId", table: "TeamRiddle");
            migrationBuilder.DropForeignKey(name: "FK_TeamRiddle_Team_TeamId", table: "TeamRiddle");
            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Team",
                nullable: false,
                defaultValue: 0);
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
            migrationBuilder.DropForeignKey(name: "FK_TeamApplicationUser_Team_TeamId", table: "TeamApplicationUser");
            migrationBuilder.DropForeignKey(name: "FK_TeamRiddle_Riddle_RiddleId", table: "TeamRiddle");
            migrationBuilder.DropForeignKey(name: "FK_TeamRiddle_Team_TeamId", table: "TeamRiddle");
            migrationBuilder.DropColumn(name: "Points", table: "Team");
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
