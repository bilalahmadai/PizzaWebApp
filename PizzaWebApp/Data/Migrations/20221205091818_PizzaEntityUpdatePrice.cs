using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWebApp.Data.Migrations
{
    public partial class PizzaEntityUpdatePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Pizza",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pizza");
        }
    }
}
