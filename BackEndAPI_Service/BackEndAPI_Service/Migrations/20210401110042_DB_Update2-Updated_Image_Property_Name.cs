using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndAPI_Service.Migrations
{
    public partial class DB_Update2Updated_Image_Property_Name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Drinks",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Drinks",
                newName: "Image");
        }
    }
}
