using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class entitiesall10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "WishList",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "User_ShoppingCartProducts",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "ShopGroup",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "sales",
                table: "Order",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "dbo",
                table: "Address",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "WishList");

            migrationBuilder.DropColumn(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "User_ShoppingCartProducts");

            migrationBuilder.DropColumn(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "ShopGroup");

            migrationBuilder.DropColumn(
                name: "Account_id",
                schema: "sales",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Account_id",
                schema: "dbo",
                table: "Address");
        }
    }
}
