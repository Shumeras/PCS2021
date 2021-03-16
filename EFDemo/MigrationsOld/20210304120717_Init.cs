//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//namespace EFDemo.Migrations.Old
//{
//    public partial class Init : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Customers",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Customers", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "Products",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
//                    Price = table.Column<float>(type: "real", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Products", x => x.Id);
//                });

//            migrationBuilder.CreateTable(
//                name: "Orders",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
//                    CustomerId = table.Column<int>(type: "int", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Orders", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_Orders_Customers_CustomerId",
//                        column: x => x.CustomerId,
//                        principalTable: "Customers",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Restrict);
//                });

//            migrationBuilder.CreateTable(
//                name: "OrderProducts",
//                columns: table => new
//                {
//                    Id = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    Quantity = table.Column<int>(type: "int", nullable: false),
//                    OrderId = table.Column<int>(type: "int", nullable: true),
//                    ProductId = table.Column<int>(type: "int", nullable: true)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
//                    table.ForeignKey(
//                        name: "FK_OrderProducts_Orders_OrderId",
//                        column: x => x.OrderId,
//                        principalTable: "Orders",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Restrict);
//                    table.ForeignKey(
//                        name: "FK_OrderProducts_Products_ProductId",
//                        column: x => x.ProductId,
//                        principalTable: "Products",
//                        principalColumn: "Id",
//                        onDelete: ReferentialAction.Restrict);
//                });

//            migrationBuilder.CreateIndex(
//                name: "IX_OrderProducts_OrderId",
//                table: "OrderProducts",
//                column: "OrderId");

//            migrationBuilder.CreateIndex(
//                name: "IX_OrderProducts_ProductId",
//                table: "OrderProducts",
//                column: "ProductId");

//            migrationBuilder.CreateIndex(
//                name: "IX_Orders_CustomerId",
//                table: "Orders",
//                column: "CustomerId");
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "OrderProducts");

//            migrationBuilder.DropTable(
//                name: "Orders");

//            migrationBuilder.DropTable(
//                name: "Products");

//            migrationBuilder.DropTable(
//                name: "Customers");
//        }
//    }
//}
