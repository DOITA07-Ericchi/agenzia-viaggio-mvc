using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bootstraptravelagencyMVC.Migrations
{
    /// <inheritdoc />
    public partial class Destinazioni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumDestinazioni",
                table: "Viaggi",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumDestinazioni",
                table: "Viaggi");
        }
    }
}
