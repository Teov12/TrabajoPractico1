using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpTeoEF.Migrations
{
    public partial class foto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "foto",
                table: "libros",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "foto",
                table: "libros");
            
        }
    }
}
