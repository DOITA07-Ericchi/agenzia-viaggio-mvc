using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bootstraptravelagencyMVC.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseRifatto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPartenza",
                table: "Viaggi");

            migrationBuilder.DropColumn(
                name: "PaeseArrivo",
                table: "Destinazioni");

            migrationBuilder.RenameColumn(
                name: "SettimaneViaggio",
                table: "Viaggi",
                newName: "GiorniViaggio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GiorniViaggio",
                table: "Viaggi",
                newName: "SettimaneViaggio");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataPartenza",
                table: "Viaggi",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PaeseArrivo",
                table: "Destinazioni",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
