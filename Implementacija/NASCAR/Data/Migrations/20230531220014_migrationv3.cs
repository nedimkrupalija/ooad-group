using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASCAR.Data.Migrations
{
    public partial class migrationv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_RegisteredUserId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Address_AdressId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_CardDetails_CardDetailsCardNumber",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_DriversLicence_LicenceId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_AdressId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CardDetailsCardNumber",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_LicenceId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CardDetailsCardNumber",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LicenceId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "User");

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admin_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RegisteredUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CardDetailsCardNumber = table.Column<int>(type: "int", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdressId = table.Column<int>(type: "int", nullable: true),
                    LicenceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisteredUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegisteredUser_Address_AdressId",
                        column: x => x.AdressId,
                        principalTable: "Address",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RegisteredUser_CardDetails_CardDetailsCardNumber",
                        column: x => x.CardDetailsCardNumber,
                        principalTable: "CardDetails",
                        principalColumn: "CardNumber");
                    table.ForeignKey(
                        name: "FK_RegisteredUser_DriversLicence_LicenceId",
                        column: x => x.LicenceId,
                        principalTable: "DriversLicence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegisteredUser_User_Id",
                        column: x => x.Id,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredUser_AdressId",
                table: "RegisteredUser",
                column: "AdressId");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredUser_CardDetailsCardNumber",
                table: "RegisteredUser",
                column: "CardDetailsCardNumber");

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredUser_LicenceId",
                table: "RegisteredUser",
                column: "LicenceId");

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
                name: "FK_Reservation_RegisteredUser_RegisteredUserId",
                table: "Reservation");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "RegisteredUser");

            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CardDetailsCardNumber",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LicenceId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_User_AdressId",
                table: "User",
                column: "AdressId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CardDetailsCardNumber",
                table: "User",
                column: "CardDetailsCardNumber");

            migrationBuilder.CreateIndex(
                name: "IX_User_LicenceId",
                table: "User",
                column: "LicenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_RegisteredUserId",
                table: "Reservation",
                column: "RegisteredUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Address_AdressId",
                table: "User",
                column: "AdressId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_CardDetails_CardDetailsCardNumber",
                table: "User",
                column: "CardDetailsCardNumber",
                principalTable: "CardDetails",
                principalColumn: "CardNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_User_DriversLicence_LicenceId",
                table: "User",
                column: "LicenceId",
                principalTable: "DriversLicence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
