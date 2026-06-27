using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackBelt.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Nascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Tipo_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenhaHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Login = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logins_Usuarios_Id_Usuario",
                        column: x => x.Id_Usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Turmas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Instrutor = table.Column<int>(type: "int", nullable: false),
                    Horario = table.Column<TimeOnly>(type: "time", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Dt_Cadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turmas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turmas_Usuarios_Id_Instrutor",
                        column: x => x.Id_Instrutor,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dt_Nascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Faixa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Turma = table.Column<int>(type: "int", nullable: false),
                    Dt_Matricula = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Turmas_Id_Turma",
                        column: x => x.Id_Turma,
                        principalTable: "Turmas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dt_Aula = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Turma = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aulas_Turmas_Id_Turma",
                        column: x => x.Id_Turma,
                        principalTable: "Turmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presencas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Turma = table.Column<int>(type: "int", nullable: false),
                    Id_Aluno = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presencas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Presencas_Alunos_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presencas_Turmas_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "Turmas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_Id_Turma",
                table: "Alunos",
                column: "Id_Turma");

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_Id_Turma",
                table: "Aulas",
                column: "Id_Turma");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_Id_Usuario",
                table: "Logins",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Presencas_Id_Aluno",
                table: "Presencas",
                column: "Id_Aluno");

            migrationBuilder.CreateIndex(
                name: "IX_Turmas_Id_Instrutor",
                table: "Turmas",
                column: "Id_Instrutor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Presencas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Turmas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
