using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TylersWebPage.Data.Migrations
{
    /// <inheritdoc />
    public partial class datetime2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Suggestion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)); //having issues with this <-----------------
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Suggestion");
        }
    }
}
