using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASCAR.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiscountId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_DiscountId",
                table: "Reservation",
                column: "DiscountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Discount_DiscountId",
                table: "Reservation",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Discount_DiscountId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_DiscountId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Reservation");
        }
    }
}
