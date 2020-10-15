using Microsoft.EntityFrameworkCore.Migrations;

namespace _8_1.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThingToDo1",
                table: "Destination",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThingToDo2",
                table: "Destination",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThingToDo3",
                table: "Destination",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThingToDo1",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "ThingToDo2",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "ThingToDo3",
                table: "Destination");
        }
    }
}
