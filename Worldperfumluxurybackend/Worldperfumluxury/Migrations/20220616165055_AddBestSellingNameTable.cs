using Microsoft.EntityFrameworkCore.Migrations;

namespace Worldperfumluxury.Migrations
{
    public partial class AddBestSellingNameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "BestSellings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "BestSellings");
        }
    }
}
