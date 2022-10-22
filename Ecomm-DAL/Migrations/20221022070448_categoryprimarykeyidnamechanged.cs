using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecomm_DAL.Migrations
{
    public partial class categoryprimarykeyidnamechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "ProductCategories",
                newName: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "ProductCategories",
                newName: "CategoryID");
        }
    }
}
