using Microsoft.EntityFrameworkCore.Migrations;

namespace Worldperfumluxury.Migrations
{
    public partial class ChangeBestSellingTableAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "BestSellings");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "BestSellings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "BestSellings");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "BestSellings",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
