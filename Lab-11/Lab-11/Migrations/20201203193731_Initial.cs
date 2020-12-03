using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab_11.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Employee");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfHire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SalesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Quarter = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SalesId);
                    table.ForeignKey(
                        name: "FK_Sales_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "DateOfHire", "FirstName", "LastName", "ManagerId" },
                values: new object[] { 1, new DateTime(1700, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1750, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santa", "Clause", 0 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "DateOfHire", "FirstName", "LastName", "ManagerId" },
                values: new object[] { 2, new DateTime(1996, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Doe", 1 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "DateOfHire", "FirstName", "LastName", "ManagerId" },
                values: new object[] { 3, new DateTime(1987, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_EmployeeId",
                table: "Sales",
                column: "EmployeeId");
        }
    }
}