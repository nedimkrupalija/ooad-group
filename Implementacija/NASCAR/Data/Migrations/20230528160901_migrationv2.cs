using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASCAR.Data.Migrations
{
    public partial class migrationv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Discount_discountId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_PaymentTypeEnum_returnTimeid",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_userId",
                table: "Reservation");

            

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_CategoryEnum_categoryId",
                table: "Vehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_TransmissionEnum_transmissionid",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "CategoryEnum");

            migrationBuilder.DropTable(
                name: "PaymentTypeEnum");

            migrationBuilder.DropTable(
                name: "TransmissionEnum");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_categoryId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_transmissionid",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_returnTimeid",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "picture",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "transmissionid",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "pickUp",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "returnTimeid",
                table: "Reservation");

            migrationBuilder.RenameColumn(
                name: "seats",
                table: "Vehicle",
                newName: "Seats");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Vehicle",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "modelYear",
                table: "Vehicle",
                newName: "ModelYear");

            migrationBuilder.RenameColumn(
                name: "mileage",
                table: "Vehicle",
                newName: "Mileage");

            migrationBuilder.RenameColumn(
                name: "isReserved",
                table: "Vehicle",
                newName: "IsReserved");

            migrationBuilder.RenameColumn(
                name: "doors",
                table: "Vehicle",
                newName: "Doors");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Vehicle",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "Vehicle",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "vehicleId",
                table: "Reservation",
                newName: "VehicleId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Reservation",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "discountId",
                table: "Reservation",
                newName: "DiscountId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_vehicleId",
                table: "Reservation",
                newName: "IX_Reservation_VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_userId",
                table: "Reservation",
                newName: "IX_Reservation_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_discountId",
                table: "Reservation",
                newName: "IX_Reservation_DiscountId");

            migrationBuilder.AlterColumn<int>(
                name: "Seats",
                table: "Vehicle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Vehicle",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "ModelYear",
                table: "Vehicle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Mileage",
                table: "Vehicle",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<bool>(
                name: "IsReserved",
                table: "Vehicle",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "Doors",
                table: "Vehicle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Vehicle",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Picutre",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Transmission",
                table: "Vehicle",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddColumn<int>(
                name: "PaymentType",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickUpDate",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegisteredUserId",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DiscountPercent",
                table: "Discount",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DiscountTotal",
                table: "Discount",
                type: "float",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardDetails",
                columns: table => new
                {
                    CardNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CVV = table.Column<int>(type: "int", nullable: true),
                    dateOfExpiry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardDetails", x => x.CardNumber);
                });

            migrationBuilder.CreateTable(
                name: "DriversLicence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpiryDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasBCategory = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriversLicence", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_RegisteredUserId",
                table: "Reservation",
                column: "RegisteredUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Discount_DiscountId",
                table: "Reservation",
                column: "DiscountId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_RegisteredUserId",
                table: "Reservation",
                column: "RegisteredUserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_UserId",
                table: "Reservation",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Vehicle_VehicleId",
                table: "Reservation",
                column: "VehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Discount_DiscountId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_RegisteredUserId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_User_UserId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Vehicle_VehicleId",
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

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "CardDetails");

            migrationBuilder.DropTable(
                name: "DriversLicence");

            migrationBuilder.DropIndex(
                name: "IX_User_AdressId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_CardDetailsCardNumber",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_LicenceId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_RegisteredUserId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Picutre",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Transmission",
                table: "Vehicle");

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

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "PickUpDate",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "RegisteredUserId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "DiscountPercent",
                table: "Discount");

            migrationBuilder.DropColumn(
                name: "DiscountTotal",
                table: "Discount");

            migrationBuilder.RenameColumn(
                name: "Seats",
                table: "Vehicle",
                newName: "seats");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Vehicle",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "ModelYear",
                table: "Vehicle",
                newName: "modelYear");

            migrationBuilder.RenameColumn(
                name: "Mileage",
                table: "Vehicle",
                newName: "mileage");

            migrationBuilder.RenameColumn(
                name: "IsReserved",
                table: "Vehicle",
                newName: "isReserved");

            migrationBuilder.RenameColumn(
                name: "Doors",
                table: "Vehicle",
                newName: "doors");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Vehicle",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Vehicle",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Reservation",
                newName: "vehicleId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reservation",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "DiscountId",
                table: "Reservation",
                newName: "discountId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_VehicleId",
                table: "Reservation",
                newName: "IX_Reservation_vehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_UserId",
                table: "Reservation",
                newName: "IX_Reservation_userId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservation_DiscountId",
                table: "Reservation",
                newName: "IX_Reservation_discountId");

            migrationBuilder.AlterColumn<int>(
                name: "seats",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "price",
                table: "Vehicle",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "modelYear",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "mileage",
                table: "Vehicle",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isReserved",
                table: "Vehicle",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "doors",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "color",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "picture",
                table: "Vehicle",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "transmissionid",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "pickUp",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "returnTimeid",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategoryEnum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEnum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypeEnum",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypeEnum", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TransmissionEnum",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransmissionEnum", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_categoryId",
                table: "Vehicle",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_transmissionid",
                table: "Vehicle",
                column: "transmissionid");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_returnTimeid",
                table: "Reservation",
                column: "returnTimeid");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Discount_discountId",
                table: "Reservation",
                column: "discountId",
                principalTable: "Discount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_PaymentTypeEnum_returnTimeid",
                table: "Reservation",
                column: "returnTimeid",
                principalTable: "PaymentTypeEnum",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_User_userId",
                table: "Reservation",
                column: "userId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Vehicle_vehicleId",
                table: "Reservation",
                column: "vehicleId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_CategoryEnum_categoryId",
                table: "Vehicle",
                column: "categoryId",
                principalTable: "CategoryEnum",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_TransmissionEnum_transmissionid",
                table: "Vehicle",
                column: "transmissionid",
                principalTable: "TransmissionEnum",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
