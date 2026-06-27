using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackBelt.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Alunos_Id_Aluno",
                table: "Presencas");

            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Turmas_Id_Aluno",
                table: "Presencas");

            migrationBuilder.AddColumn<int>(
                name: "AlunoId",
                table: "Presencas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurmaId",
                table: "Presencas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Presencas_AlunoId",
                table: "Presencas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Presencas_Id_Turma",
                table: "Presencas",
                column: "Id_Turma");

            migrationBuilder.CreateIndex(
                name: "IX_Presencas_TurmaId",
                table: "Presencas",
                column: "TurmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Alunos_AlunoId",
                table: "Presencas",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Alunos_Id_Aluno",
                table: "Presencas",
                column: "Id_Aluno",
                principalTable: "Alunos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Turmas_Id_Turma",
                table: "Presencas",
                column: "Id_Turma",
                principalTable: "Turmas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Turmas_TurmaId",
                table: "Presencas",
                column: "TurmaId",
                principalTable: "Turmas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Alunos_AlunoId",
                table: "Presencas");

            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Alunos_Id_Aluno",
                table: "Presencas");

            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Turmas_Id_Turma",
                table: "Presencas");

            migrationBuilder.DropForeignKey(
                name: "FK_Presencas_Turmas_TurmaId",
                table: "Presencas");

            migrationBuilder.DropIndex(
                name: "IX_Presencas_AlunoId",
                table: "Presencas");

            migrationBuilder.DropIndex(
                name: "IX_Presencas_Id_Turma",
                table: "Presencas");

            migrationBuilder.DropIndex(
                name: "IX_Presencas_TurmaId",
                table: "Presencas");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Presencas");

            migrationBuilder.DropColumn(
                name: "TurmaId",
                table: "Presencas");

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Alunos_Id_Aluno",
                table: "Presencas",
                column: "Id_Aluno",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Presencas_Turmas_Id_Aluno",
                table: "Presencas",
                column: "Id_Aluno",
                principalTable: "Turmas",
                principalColumn: "Id");
        }
    }
}
