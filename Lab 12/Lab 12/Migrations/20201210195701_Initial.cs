using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab_12.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accomodation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccomodationEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccomodationPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThingToDo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingToDo2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThingToDo3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                });
        }
    }
}