using Microsoft.EntityFrameworkCore.Migrations;

namespace _4_1.Migrations
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
                    CategoryID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    FName = table.Column<string>(nullable: false),
                    LName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.FName);
                    table.ForeignKey(
                        name: "FK_Contacts_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 1, "Friend" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 2, "Work" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 3, "Family" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "FName", "LName", "CategoryID", "Email", "PhoneNumber" },
                values: new object[] { "Jane", "Doe", 1, "janedoe@gmail.com", 9999 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "FName", "LName", "CategoryID", "Email", "PhoneNumber" },
                values: new object[] { "John", "Doe,", 3, "johndoe@gmail.com", 1111 });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "FName", "LName", "CategoryID", "Email", "PhoneNumber" },
                values: new object[] { "Mary", "Johnson", 3, "maryjohnson@gmail.com", 2222 });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryID",
                table: "Contacts",
                column: "CategoryID");
        }
    }
}