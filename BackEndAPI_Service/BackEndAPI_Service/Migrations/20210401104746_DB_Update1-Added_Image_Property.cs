using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndAPI_Service.Migrations
{
    public partial class DB_Update1Added_Image_Property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Drinks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Drinks");
        }
    }
}
