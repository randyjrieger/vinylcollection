using Microsoft.EntityFrameworkCore.Migrations;

namespace VinylCollection.Migrations
{
    public partial class updateTitleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AlbumName",
                table: "Records",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Records",
                newName: "AlbumName");
        }
    }
}
