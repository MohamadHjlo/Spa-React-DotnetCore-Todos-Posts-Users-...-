using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaReduxDotNet.Migrations
{
    public partial class adddescribtionuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Describtion",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Describtion",
                table: "Users");
        }
    }
}
