using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission5.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Title);
                    table.ForeignKey(
                        name: "FK_movies_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Action" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "SciFi" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Romance" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Comedy" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "Title", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Inception", 1, "Christopher Nolan", false, null, null, "PG-13", 2010 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "Title", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Batman Begins", 1, "Christopher Nolan", false, null, null, "PG-13", 2005 });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "Title", "CategoryId", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "The Martian", 2, "Ridley Scott", false, null, null, "PG-13", 2015 });

            migrationBuilder.CreateIndex(
                name: "IX_movies_CategoryId",
                table: "movies",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
