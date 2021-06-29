using Microsoft.EntityFrameworkCore.Migrations;

namespace NgocHaishop.Data.Migrations
{
    public partial class CartUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cart_Adress",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cart_Name",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cart_PhoneNumber",
                table: "Carts",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cart_Adress",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Cart_Name",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Cart_PhoneNumber",
                table: "Carts");
        }
    }
}
