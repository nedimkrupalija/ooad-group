using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASCAR.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DropDate",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Price",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DropDate",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Reservation");
        }
    }
}
