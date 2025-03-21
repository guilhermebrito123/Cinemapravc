using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemapravc.Migrations
{
    public partial class UpdateFilmes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Genero",
                newName: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Genero",
                newName: "Descricao");
        }
    }
}
