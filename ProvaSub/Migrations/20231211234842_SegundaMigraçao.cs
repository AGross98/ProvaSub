using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaSub.Migrations
{
    public partial class SegundaMigraçao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imc",
                columns: table => new
                {
                    ImcID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AlunoID = table.Column<int>(type: "INTEGER", nullable: false),
                    Altura = table.Column<float>(type: "REAL", nullable: false),
                    Peso = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imc", x => x.ImcID);
                    table.ForeignKey(
                        name: "FK_Imc_Aluno_AlunoID",
                        column: x => x.AlunoID,
                        principalTable: "Aluno",
                        principalColumn: "AlunoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imc_AlunoID",
                table: "Imc",
                column: "AlunoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imc");
        }
    }
}
