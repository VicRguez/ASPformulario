using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPPrueba.Migrations
{
    public partial class AñadirTablitaPregunta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "preguntas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextoPregunta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PosiblesRespuestas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoPregunta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_preguntas", x => x.Id);
                });
        }



        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "preguntas");
        }
    }
}
