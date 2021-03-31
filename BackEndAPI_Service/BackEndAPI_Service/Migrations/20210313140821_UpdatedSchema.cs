using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndAPI_Service.Migrations
{
    public partial class UpdatedSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Drinks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Drinks");
        }
    }
}
