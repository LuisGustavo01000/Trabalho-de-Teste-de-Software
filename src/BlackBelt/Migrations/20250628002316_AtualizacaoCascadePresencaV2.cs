using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackBelt.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoCascadePresencaV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Alunos_Id_Aluno",
                table: "Presencas");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Alunos_Id_Aluno",
                table: "Presencas",
                column: "Id_Aluno",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Alunos_Id_Aluno",
                table: "Presencas");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Alunos_Id_Aluno",
                table: "Presencas",
                column: "Id_Aluno",
                principalTable: "Alunos",
                principalColumn: "Id");
        }
    }
}
