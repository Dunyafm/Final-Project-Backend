using Microsoft.EntityFrameworkCore.Migrations;

namespace Worldperfumluxury.Migrations
{
    public partial class ChangeProductmultiTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Desc",
                table: "Productmultis",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Productmultis",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Productmultis");

            migrationBuilder.AlterColumn<int>(
                name: "Desc",
                table: "Productmultis",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
