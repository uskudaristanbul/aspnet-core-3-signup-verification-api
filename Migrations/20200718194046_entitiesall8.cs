using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class entitiesall8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CareerName",
                schema: "dbo",
                table: "Career");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CareerName",
                schema: "dbo",
                table: "Career",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }
    }
}
