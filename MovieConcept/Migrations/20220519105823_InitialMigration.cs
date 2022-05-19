using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieConcept.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "titles.movies",
                columns: table => new
                {
                    tconst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    titleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    primaryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    originalTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startYear = table.Column<int>(type: "int", nullable: false),
                    runtimeMinutes = table.Column<int>(type: "int", nullable: false),
                    genres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titles.movies", x => x.tconst);
                });

            migrationBuilder.CreateTable(
                name: "principals",
                columns: table => new
                {
                    gtin = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tconst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ordering = table.Column<int>(type: "int", nullable: false),
                    nconst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_principals", x => x.gtin);
                    table.ForeignKey(
                        name: "FK_principals_titles.movies_tconst",
                        column: x => x.tconst,
                        principalTable: "titles.movies",
                        principalColumn: "tconst");
                });

            migrationBuilder.CreateTable(
                name: "titles.ratings",
                columns: table => new
                {
                    tconst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    averageRating = table.Column<double>(type: "float", nullable: true),
                    numVotes = table.Column<int>(type: "int", nullable: false),
                    MovieTitleTconst = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titles.ratings", x => x.tconst);
                    table.ForeignKey(
                        name: "FK_titles.ratings_titles.movies_MovieTitleTconst",
                        column: x => x.MovieTitleTconst,
                        principalTable: "titles.movies",
                        principalColumn: "tconst");
                });

            migrationBuilder.CreateIndex(
                name: "IX_principals_tconst",
                table: "principals",
                column: "tconst");

            migrationBuilder.CreateIndex(
                name: "IX_titles.ratings_MovieTitleTconst",
                table: "titles.ratings",
                column: "MovieTitleTconst");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "principals");

            migrationBuilder.DropTable(
                name: "titles.ratings");

            migrationBuilder.DropTable(
                name: "titles.movies");
        }
    }
}
