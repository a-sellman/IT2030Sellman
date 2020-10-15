using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace _8_1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destination");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    TripID = table.Column<string>(nullable: false),
                    EndDate = table.Column<int>(nullable: false),
                    StartDate = table.Column<int>(nullable: false),
                    AccomodationName = table.Column<string>(nullable: false),
                    AccomodationEmail = table.Column<string>(nullable: false),
                    AccomdationPhone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.TripID);
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "TripID", "EndDate", "StartDate", "AccomodationName", "AccomodationEmail", "AccomodationPhone" },
                values: new object[] { "New York", 2020, 2020 });
        }
    }
}