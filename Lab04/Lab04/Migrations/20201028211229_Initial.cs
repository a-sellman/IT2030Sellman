using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab04.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Categories");
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    Lastname = table.Column<string>(nullable: false),
                    Organization = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Family" },
                    { 2, "Friend" },
                    { 3, "Work" },
                    { 4, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryID", "DateAdded", "Email", "Firstname", "Lastname", "Organization", "Phone" },
                values: new object[] { 1, 1, new DateTime(2020, 10, 28, 17, 12, 28, 760, DateTimeKind.Local).AddTicks(7124), "janedoe@gmail.com", "Jane", "Doe", null, "111-222-333" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryID", "DateAdded", "Email", "Firstname", "Lastname", "Organization", "Phone" },
                values: new object[] { 2, 2, new DateTime(2020, 10, 28, 17, 12, 28, 768, DateTimeKind.Local).AddTicks(4020), "johndoe@gmail.com", "John", "Doe", null, "444-555-6666" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "CategoryID", "DateAdded", "Email", "Firstname", "Lastname", "Organization", "Phone" },
                values: new object[] { 3, 3, new DateTime(2020, 10, 28, 17, 12, 28, 768, DateTimeKind.Local).AddTicks(4194), "maryhart@gmail.com", "Mary", "Hart", null, "999-999-999" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryID",
                table: "Contacts",
                column: "CategoryID");
        }
    }
}