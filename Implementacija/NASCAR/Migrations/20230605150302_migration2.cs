using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASCAR.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Reservation_ResetvationId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_ResetvationId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "ResetvationId",
                table: "Vehicle");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_VehicleId",
                table: "Reservation",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Vehicle_VehicleId",
                table: "Reservation",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Vehicle_VehicleId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_VehicleId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Reservation");

            migrationBuilder.AddColumn<int>(
                name: "ResetvationId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ResetvationId",
                table: "Vehicle",
                column: "ResetvationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Reservation_ResetvationId",
                table: "Vehicle",
                column: "ResetvationId",
                principalTable: "Reservation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
