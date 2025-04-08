using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoAluno.Data.Migrations
{
    public partial class addCamposStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Alunos");
        }
    }
}
