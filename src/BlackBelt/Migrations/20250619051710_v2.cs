using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackBelt.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Presencas",
                newName: "Presente");

            migrationBuilder.AddColumn<DateTime>(
                name: "Dt_Aula",
                table: "Presencas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dt_Aula",
                table: "Presencas");

            migrationBuilder.RenameColumn(
                name: "Presente",
                table: "Presencas",
                newName: "Status");

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Turma = table.Column<int>(type: "int", nullable: false),
                    Dt_Aula = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_Id_Turma",
                table: "Aulas",
                column: "Id_Turma");
        }
    }
}
