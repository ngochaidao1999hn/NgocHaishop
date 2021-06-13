using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NgocHaishop.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Brand_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pro_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Brand_id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Cate_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cate_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cate_Status = table.Column<int>(type: "int", nullable: false),
                    Cate_Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Cate_Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Cus_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cus_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cus_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cus_Phone = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Cus_Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Pro_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pro_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pro_Quantity = table.Column<int>(type: "int", nullable: false),
                    Pro_Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Pro_Star = table.Column<int>(type: "int", nullable: false),
                    Pro_Category = table.Column<int>(type: "int", nullable: false),
                    Pro_Brand = table.Column<int>(type: "int", nullable: false),
                    Pro_Status = table.Column<int>(type: "int", nullable: false),
                    Pro_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pro_VỉewCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Pro_Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_Pro_Brand",
                        column: x => x.Pro_Brand,
                        principalTable: "Brands",
                        principalColumn: "Brand_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_Pro_Category",
                        column: x => x.Pro_Category,
                        principalTable: "Categories",
                        principalColumn: "Cate_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Acc_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acc_UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acc_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acc_Customer = table.Column<int>(type: "int", nullable: false),
                    Acc_Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Acc_Id);
                    table.ForeignKey(
                        name: "FK_Accounts_Customers_Acc_Customer",
                        column: x => x.Acc_Customer,
                        principalTable: "Customers",
                        principalColumn: "Cus_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Cart_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<int>(type: "int", nullable: false),
                    Cart_CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cart_Status = table.Column<int>(type: "int", nullable: false),
                    Cart_Promo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Cart_Id);
                    table.ForeignKey(
                        name: "FK_Carts_Customers_Customer_Id",
                        column: x => x.Customer_Id,
                        principalTable: "Customers",
                        principalColumn: "Cus_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Review_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review_Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Review_Product = table.Column<int>(type: "int", nullable: false),
                    Review_Customer = table.Column<int>(type: "int", nullable: false),
                    Review_Star = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Review_Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_Review_Customer",
                        column: x => x.Review_Customer,
                        principalTable: "Customers",
                        principalColumn: "Cus_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_Review_Product",
                        column: x => x.Review_Product,
                        principalTable: "Products",
                        principalColumn: "Pro_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetails",
                columns: table => new
                {
                    Detail_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail_Product = table.Column<int>(type: "int", nullable: false),
                    Detail_Cart = table.Column<int>(type: "int", nullable: false),
                    Detail_Quantity = table.Column<int>(type: "int", nullable: false),
                    Detail_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetails", x => x.Detail_Id);
                    table.ForeignKey(
                        name: "FK_CartDetails_Carts_Detail_Cart",
                        column: x => x.Detail_Cart,
                        principalTable: "Carts",
                        principalColumn: "Cart_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetails_Products_Detail_Product",
                        column: x => x.Detail_Product,
                        principalTable: "Products",
                        principalColumn: "Pro_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_Acc_Customer",
                table: "Accounts",
                column: "Acc_Customer");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_Detail_Cart",
                table: "CartDetails",
                column: "Detail_Cart");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetails_Detail_Product",
                table: "CartDetails",
                column: "Detail_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_Customer_Id",
                table: "Carts",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Pro_Brand",
                table: "Products",
                column: "Pro_Brand");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Pro_Category",
                table: "Products",
                column: "Pro_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Review_Customer",
                table: "Reviews",
                column: "Review_Customer");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Review_Product",
                table: "Reviews",
                column: "Review_Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "CartDetails");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
