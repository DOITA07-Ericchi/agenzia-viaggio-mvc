using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bootstraptravelagencyMVC.Migrations
{
    /// <inheritdoc />
    public partial class PrimaMigrazione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destinazioni",
                columns: table => new
                {
                    DestinazioneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CittaArrivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaeseArrivo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinazioni", x => x.DestinazioneId);
                });

            migrationBuilder.CreateTable(
                name: "Viaggi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeViaggio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinazioneId = table.Column<int>(type: "int", nullable: false),
                    DataPartenza = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SettimaneViaggio = table.Column<int>(type: "int", nullable: false),
                    Prezzo = table.Column<double>(type: "float", nullable: false),
                    ColorCard = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viaggi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viaggi_Destinazioni_DestinazioneId",
                        column: x => x.DestinazioneId,
                        principalTable: "Destinazioni",
                        principalColumn: "DestinazioneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Viaggi_DestinazioneId",
                table: "Viaggi",
                column: "DestinazioneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viaggi");

            migrationBuilder.DropTable(
                name: "Destinazioni");
        }
    }
}
