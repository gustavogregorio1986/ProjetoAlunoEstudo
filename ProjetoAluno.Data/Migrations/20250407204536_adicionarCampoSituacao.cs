using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAluno.Data.Migrations
{
    public partial class adicionarCampoSituacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Situacao",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Alunos");
        }
    }
}
