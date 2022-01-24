using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Inception", "Action", "Christopher Nolan", false, null, null, "PG-13", 2010 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "The Martian", "SciFi", "Ridley Scott", false, null, null, "PG-13", 2015 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Batman Begins", "Action", "Christopher Nolan", false, null, null, "PG-13", 2005 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
