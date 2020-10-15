using Microsoft.EntityFrameworkCore.Migrations;

namespace _8_1.Migrations
{
    public partial class Init : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccomodationEmail",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "AccomodationName",
                table: "Destination");

            migrationBuilder.DropColumn(
                name: "AccomodationPhone",
                table: "Destination");

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "TripID", "EndDate", "StartDate" },
                values: new object[] { "New York", 2020, 2020 });
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Destination",
                keyColumn: "TripID",
                keyValue: "New York");

            migrationBuilder.AddColumn<string>(
                name: "AccomodationEmail",
                table: "Destination",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccomodationName",
                table: "Destination",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccomodationPhone",
                table: "Destination",
                nullable: true);
        }
    }
}