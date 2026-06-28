using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlackBelt.Migrations
{
    /// <inheritdoc />
    public partial class AtualizacaoHabilidadesV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Avaliação",
                table: "Habilidades",
                newName: "Avaliacao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Avaliacao",
                table: "Habilidades",
                newName: "Avaliação");
        }
    }
}
