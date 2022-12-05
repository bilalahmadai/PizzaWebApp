using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWebApp.Data.Migrations
{
    public partial class pizzaCheffRelationCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CheffFID",
                table: "Pizza",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_CheffFID",
                table: "Pizza",
                column: "CheffFID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Cheff_CheffFID",
                table: "Pizza",
                column: "CheffFID",
                principalTable: "Cheff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Cheff_CheffFID",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_CheffFID",
                table: "Pizza");

            migrationBuilder.DropColumn(
                name: "CheffFID",
                table: "Pizza");
        }
    }
}
