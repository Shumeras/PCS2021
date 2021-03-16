//using Microsoft.EntityFrameworkCore.Migrations;

//namespace EFDemo.Migrations.Old
//{
//    public partial class UpdatedDB : Migration
//    {
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Orders_Customers_CustomerId",
//                table: "Orders");

//            migrationBuilder.AlterColumn<string>(
//                name: "Name",
//                table: "Products",
//                type: "nvarchar(64)",
//                maxLength: 64,
//                nullable: false,
//                defaultValue: "",
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)",
//                oldNullable: true);

//            migrationBuilder.AlterColumn<int>(
//                name: "CustomerId",
//                table: "Orders",
//                type: "int",
//                nullable: false,
//                defaultValue: 0,
//                oldClrType: typeof(int),
//                oldType: "int",
//                oldNullable: true);

//            migrationBuilder.AlterColumn<string>(
//                name: "FirstName",
//                table: "Customers",
//                type: "nvarchar(64)",
//                maxLength: 64,
//                nullable: false,
//                defaultValue: "",
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)",
//                oldNullable: true);

//            migrationBuilder.AlterColumn<string>(
//                name: "Address",
//                table: "Customers",
//                type: "nvarchar(256)",
//                maxLength: 256,
//                nullable: true,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(max)",
//                oldNullable: true);

//            migrationBuilder.AddColumn<string>(
//                name: "LastName",
//                table: "Customers",
//                type: "nvarchar(64)",
//                maxLength: 64,
//                nullable: false,
//                defaultValue: "");

//            migrationBuilder.AddForeignKey(
//                name: "FK_Orders_Customers_CustomerId",
//                table: "Orders",
//                column: "CustomerId",
//                principalTable: "Customers",
//                principalColumn: "Id",
//                onDelete: ReferentialAction.Cascade);
//        }

//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropForeignKey(
//                name: "FK_Orders_Customers_CustomerId",
//                table: "Orders");

//            migrationBuilder.DropColumn(
//                name: "LastName",
//                table: "Customers");

//            migrationBuilder.AlterColumn<string>(
//                name: "Name",
//                table: "Products",
//                type: "nvarchar(max)",
//                nullable: true,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(64)",
//                oldMaxLength: 64);

//            migrationBuilder.AlterColumn<int>(
//                name: "CustomerId",
//                table: "Orders",
//                type: "int",
//                nullable: true,
//                oldClrType: typeof(int),
//                oldType: "int");

//            migrationBuilder.AlterColumn<string>(
//                name: "FirstName",
//                table: "Customers",
//                type: "nvarchar(max)",
//                nullable: true,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(64)",
//                oldMaxLength: 64);

//            migrationBuilder.AlterColumn<string>(
//                name: "Address",
//                table: "Customers",
//                type: "nvarchar(max)",
//                nullable: true,
//                oldClrType: typeof(string),
//                oldType: "nvarchar(256)",
//                oldMaxLength: 256,
//                oldNullable: true);

//            migrationBuilder.AddForeignKey(
//                name: "FK_Orders_Customers_CustomerId",
//                table: "Orders",
//                column: "CustomerId",
//                principalTable: "Customers",
//                principalColumn: "Id",
//                onDelete: ReferentialAction.Restrict);
//        }
//    }
//}
