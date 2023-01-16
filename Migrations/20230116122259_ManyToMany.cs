using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bootstraptravelagencyMVC.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DestinazioneViaggio",
                columns: table => new
                {
                    ListaDestinazioniDestinazioneId = table.Column<int>(type: "int", nullable: false),
                    ViaggiPerDestinazioneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinazioneViaggio", x => new { x.ListaDestinazioniDestinazioneId, x.ViaggiPerDestinazioneId });
                    table.ForeignKey(
                        name: "FK_DestinazioneViaggio_Destinazioni_ListaDestinazioniDestinazioneId",
                        column: x => x.ListaDestinazioniDestinazioneId,
                        principalTable: "Destinazioni",
                        principalColumn: "DestinazioneId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DestinazioneViaggio_Viaggi_ViaggiPerDestinazioneId",
                        column: x => x.ViaggiPerDestinazioneId,
                        principalTable: "Viaggi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DestinazioneViaggio_ViaggiPerDestinazioneId",
                table: "DestinazioneViaggio",
                column: "ViaggiPerDestinazioneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DestinazioneViaggio");
        }
    }
}
