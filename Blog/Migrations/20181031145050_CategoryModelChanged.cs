using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class CategoryModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryDescr",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryDescr",
                table: "Categories");
        }
    }
}
