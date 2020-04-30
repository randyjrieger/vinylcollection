using Microsoft.EntityFrameworkCore.Migrations;

namespace VinylCollection.Migrations
{
    public partial class updateTitleType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Records",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Title",
                table: "Records",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
