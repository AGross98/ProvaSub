using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaSub.Migrations
{
    public partial class quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imc_Aluno_AlunoID",
                table: "Imc");

            migrationBuilder.AlterColumn<int>(
                name: "AlunoID",
                table: "Imc",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Imc_Aluno_AlunoID",
                table: "Imc",
                column: "AlunoID",
                principalTable: "Aluno",
                principalColumn: "AlunoID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imc_Aluno_AlunoID",
                table: "Imc");

            migrationBuilder.AlterColumn<int>(
                name: "AlunoID",
                table: "Imc",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Imc_Aluno_AlunoID",
                table: "Imc",
                column: "AlunoID",
                principalTable: "Aluno",
                principalColumn: "AlunoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
