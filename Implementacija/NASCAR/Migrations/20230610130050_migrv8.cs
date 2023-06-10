using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASCAR.Migrations
{
    public partial class migrv8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardDetails_RegisteredUser_RegisteredUserId",
                table: "CardDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Discount_DiscountId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_RegisteredUser_RegisteredUserId",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "DriversLicence");

            migrationBuilder.DropIndex(
                name: "IX_CardDetails_RegisteredUserId",
                table: "CardDetails");

            migrationBuilder.AlterColumn<string>(
                name: "RegisteredUserId",
                table: "Reservation",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "DiscountId",
                table: "Reservation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RegisteredUserId",
                table: "CardDetails",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_CardDetails_RegisteredUserId",
                table: "CardDetails",
                column: "RegisteredUserId",
                unique: true,
                filter: "[RegisteredUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CardDetails_RegisteredUser_RegisteredUserId",
                table: "CardDetails",
                column: "RegisteredUserId",
                principalTable: "RegisteredUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Discount_DiscountId",
                table: "Reservation",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_RegisteredUser_RegisteredUserId",
                table: "Reservation",
                column: "RegisteredUserId",
                principalTable: "RegisteredUser",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardDetails_RegisteredUser_RegisteredUserId",
                table: "CardDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Discount_DiscountId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_RegisteredUser_RegisteredUserId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_CardDetails_RegisteredUserId",
                table: "CardDetails");

            migrationBuilder.AlterColumn<string>(
                name: "RegisteredUserId",
                table: "Reservation",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiscountId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RegisteredUserId",
                table: "CardDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DriversLicence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegisteredUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBCategory = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriversLicence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriversLicence_RegisteredUser_RegisteredUserId",
                        column: x => x.RegisteredUserId,
                        principalTable: "RegisteredUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardDetails_RegisteredUserId",
                table: "CardDetails",
                column: "RegisteredUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriversLicence_RegisteredUserId",
                table: "DriversLicence",
                column: "RegisteredUserId",
                unique: true,
                filter: "[RegisteredUserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CardDetails_RegisteredUser_RegisteredUserId",
                table: "CardDetails",
                column: "RegisteredUserId",
                principalTable: "RegisteredUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Discount_DiscountId",
                table: "Reservation",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_RegisteredUser_RegisteredUserId",
                table: "Reservation",
                column: "RegisteredUserId",
                principalTable: "RegisteredUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
