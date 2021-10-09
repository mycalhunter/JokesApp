using Microsoft.EntityFrameworkCore.Migrations;

namespace JokesApp.Data.Migrations
{
    public partial class documentationnotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentationNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Example = table.Column<string>(type: "nvarchar(max)", nullable: true)
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocumentationNotes");
        }
    }
}
