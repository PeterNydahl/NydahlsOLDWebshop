using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NydahlsWebshop1000.Migrations
{
    /// <inheritdoc />
    public partial class AddingImgUrlSoldOutToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrlSoldOut",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgUrlSoldOut",
                table: "Products");
        }
    }
}
