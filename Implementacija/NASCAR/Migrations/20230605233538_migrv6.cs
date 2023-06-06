using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NASCAR.Migrations
{
    public partial class migrv6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picutre",
                table: "Vehicle",
                newName: "Picture");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Vehicle",
                newName: "Picutre");
        }
    }
}
