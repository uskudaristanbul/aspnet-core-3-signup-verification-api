using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "sirname",
                schema: "tekyerco_kozmi",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "ShopGroup");

            migrationBuilder.DropColumn(
                name: "Btw_11_14Available",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_14_17Available",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_17_20Available",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_20_23Available",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_8_11Available",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "SlotDate",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Account_id",
                schema: "dbo",
                table: "Address");

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                schema: "tekyerco_kozmi",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenEndDate",
                schema: "tekyerco_kozmi",
                table: "User",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "surname",
                schema: "tekyerco_kozmi",
                table: "User",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DayOfDate",
                schema: "tekyerco_kozmi",
                table: "SlotPattern",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthOfDate",
                schema: "tekyerco_kozmi",
                table: "SlotPattern",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearOfDate",
                schema: "tekyerco_kozmi",
                table: "SlotPattern",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_11_14Available_D1",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_11_14Available_D2",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_14_17Available_D1",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_14_17Available_D2",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_17_20Available_D1",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_17_20Available_D2",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_20_23Available_D1",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_20_23Available_D2",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_8_11Available_D1",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_8_11Available_D2",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SlotDateDay_D1",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SlotDateDay_D2",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SlotDateMonth_D1",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SlotDateMonth_D2",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SlotDateYear_D1",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SlotDateYear_D2",
                schema: "dbo",
                table: "Slot",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "dbo",
                table: "Career",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CareerName",
                schema: "dbo",
                table: "Career",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                schema: "tekyerco_kozmi",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RefreshTokenEndDate",
                schema: "tekyerco_kozmi",
                table: "User");

            migrationBuilder.DropColumn(
                name: "surname",
                schema: "tekyerco_kozmi",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DayOfDate",
                schema: "tekyerco_kozmi",
                table: "SlotPattern");

            migrationBuilder.DropColumn(
                name: "MonthOfDate",
                schema: "tekyerco_kozmi",
                table: "SlotPattern");

            migrationBuilder.DropColumn(
                name: "YearOfDate",
                schema: "tekyerco_kozmi",
                table: "SlotPattern");

            migrationBuilder.DropColumn(
                name: "Btw_11_14Available_D1",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_11_14Available_D2",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_14_17Available_D1",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_14_17Available_D2",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_17_20Available_D1",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_17_20Available_D2",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_20_23Available_D1",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_20_23Available_D2",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_8_11Available_D1",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Btw_8_11Available_D2",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "SlotDateDay_D1",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "SlotDateDay_D2",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "SlotDateMonth_D1",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "SlotDateMonth_D2",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "SlotDateYear_D1",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "SlotDateYear_D2",
                schema: "dbo",
                table: "Slot");

            migrationBuilder.DropColumn(
                name: "Account_id",
                schema: "dbo",
                table: "Career");

            migrationBuilder.DropColumn(
                name: "CareerName",
                schema: "dbo",
                table: "Career");

            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "WishList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "User_ShoppingCartProducts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "sirname",
                schema: "tekyerco_kozmi",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "tekyerco_kozmi",
                table: "ShopGroup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_11_14Available",
                schema: "dbo",
                table: "Slot",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_14_17Available",
                schema: "dbo",
                table: "Slot",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_17_20Available",
                schema: "dbo",
                table: "Slot",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_20_23Available",
                schema: "dbo",
                table: "Slot",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Btw_8_11Available",
                schema: "dbo",
                table: "Slot",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SlotDate",
                schema: "dbo",
                table: "Slot",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Account_id",
                schema: "dbo",
                table: "Address",
                type: "int",
                nullable: true);
        }
    }
}
