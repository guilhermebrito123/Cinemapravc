using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemapravc.Migrations
{
    public partial class M02AddtableDiretores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiretorId",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Diretor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filme_DiretorId",
                table: "Filme",
                column: "DiretorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filme_Diretor_DiretorId",
                table: "Filme",
                column: "DiretorId",
                principalTable: "Diretor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filme_Diretor_DiretorId",
                table: "Filme");

            migrationBuilder.DropTable(
                name: "Diretor");

            migrationBuilder.DropIndex(
                name: "IX_Filme_DiretorId",
                table: "Filme");

            migrationBuilder.DropColumn(
                name: "DiretorId",
                table: "Filme");
        }
    }
}
