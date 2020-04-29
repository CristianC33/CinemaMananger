using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaManager.DataAccess.Migrations
{
    public partial class AddUserIdToEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Admins",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Users",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Users");
        }
    }
}
