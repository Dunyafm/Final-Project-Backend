using Microsoft.EntityFrameworkCore.Migrations;

namespace Worldperfumluxury.Migrations
{
    public partial class CreateProductmultiTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Productmultis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productmultis",
                table: "Productmultis",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Productmultis",
                table: "Productmultis");

            migrationBuilder.RenameTable(
                name: "Productmultis",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");
        }
    }
}
