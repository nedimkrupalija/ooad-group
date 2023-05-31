using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASCAR.Data.Migrations
{
    public partial class migrationv4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisteredUser_CardDetails_CardDetailsCardNumber",
                table: "RegisteredUser");

            migrationBuilder.DropIndex(
                name: "IX_RegisteredUser_CardDetailsCardNumber",
                table: "RegisteredUser");

            migrationBuilder.DropColumn(
                name: "CardDetailsCardNumber",
                table: "RegisteredUser");

            migrationBuilder.RenameColumn(
                name: "dateOfExpiry",
                table: "CardDetails",
                newName: "DateOfExpiry");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "AspNetUsers",
                newName: "UserName");

            migrationBuilder.AddColumn<int>(
                name: "CardDetailsId",
                table: "RegisteredUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredUser_CardDetailsId",
                table: "RegisteredUser",
                column: "CardDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_RegisteredUser_CardDetails_CardDetailsId",
                table: "RegisteredUser",
                column: "CardDetailsId",
                principalTable: "CardDetails",
                principalColumn: "CardNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisteredUser_CardDetails_CardDetailsId",
                table: "RegisteredUser");

            migrationBuilder.DropIndex(
                name: "IX_RegisteredUser_CardDetailsId",
                table: "RegisteredUser");

            migrationBuilder.DropColumn(
                name: "CardDetailsId",
                table: "RegisteredUser");

            migrationBuilder.RenameColumn(
                name: "DateOfExpiry",
                table: "CardDetails",
                newName: "dateOfExpiry");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AspNetUsers",
                newName: "Username");

            migrationBuilder.AddColumn<int>(
                name: "CardDetailsCardNumber",
                table: "RegisteredUser",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegisteredUser_CardDetailsCardNumber",
                table: "RegisteredUser",
                column: "CardDetailsCardNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_RegisteredUser_CardDetails_CardDetailsCardNumber",
                table: "RegisteredUser",
                column: "CardDetailsCardNumber",
                principalTable: "CardDetails",
                principalColumn: "CardNumber");
        }
    }
}
