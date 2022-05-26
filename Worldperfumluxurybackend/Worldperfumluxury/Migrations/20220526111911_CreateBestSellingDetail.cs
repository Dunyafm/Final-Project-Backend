using Microsoft.EntityFrameworkCore.Migrations;

namespace Worldperfumluxury.Migrations
{
    public partial class CreateBestSellingDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BestSellingDetailId",
                table: "BestSellings",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BestSellingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Seria = table.Column<string>(nullable: true),
                    Composition = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    BestSellingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestSellingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BestSellingDetails_BestSellingDetails_BestSellingId",
                        column: x => x.BestSellingId,
                        principalTable: "BestSellingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BestSellings_BestSellingDetailId",
                table: "BestSellings",
                column: "BestSellingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BestSellingDetails_BestSellingId",
                table: "BestSellingDetails",
                column: "BestSellingId");

            migrationBuilder.AddForeignKey(
                name: "FK_BestSellings_BestSellingDetails_BestSellingDetailId",
                table: "BestSellings",
                column: "BestSellingDetailId",
                principalTable: "BestSellingDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BestSellings_BestSellingDetails_BestSellingDetailId",
                table: "BestSellings");

            migrationBuilder.DropTable(
                name: "BestSellingDetails");

            migrationBuilder.DropIndex(
                name: "IX_BestSellings_BestSellingDetailId",
                table: "BestSellings");

            migrationBuilder.DropColumn(
                name: "BestSellingDetailId",
                table: "BestSellings");
        }
    }
}
