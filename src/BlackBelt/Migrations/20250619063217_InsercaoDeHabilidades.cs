using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackBelt.Migrations
{
    /// <inheritdoc />
    public partial class InsercaoDeHabilidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avaliação = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Aluno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habilidades_Alunos_Id_Aluno",
                        column: x => x.Id_Aluno,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_Id_Aluno",
                table: "Habilidades",
                column: "Id_Aluno");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Habilidades");
        }
    }
}
