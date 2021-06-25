using Microsoft.EntityFrameworkCore.Migrations;

namespace NgocHaishop.Data.Migrations
{
    public partial class Brand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pro_Description",
                table: "Brands",
                newName: "Brand_Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Brand_Description",
                table: "Brands",
                newName: "Pro_Description");
        }
    }
}
