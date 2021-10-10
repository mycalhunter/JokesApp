using Microsoft.EntityFrameworkCore.Migrations;

namespace JokesApp.Data.Migrations
{
    public partial class DocumentationNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Note",
                table: "DocumentationNotes",
                newName: "Example");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Example",
                table: "DocumentationNotes",
                newName: "Note");
        }
    }
}
