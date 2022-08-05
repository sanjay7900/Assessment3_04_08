using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookListWebApiAssessment3.Data.Migrations
{
    public partial class AddColumnmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Cart");
        }
    }
}
