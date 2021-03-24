using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FixedWrongClassUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Products",
                type: "TEXT",
                maxLength: 512,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Orders",
                type: "TEXT",
                maxLength: 512,
                nullable: true);
        }
    }
}
