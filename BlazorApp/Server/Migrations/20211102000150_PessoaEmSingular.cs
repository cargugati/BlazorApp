using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp.Server.Migrations
{
    public partial class PessoaEmSingular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Pessoa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Pessoas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "Id");
        }
    }
}
