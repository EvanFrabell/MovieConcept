using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieConcept.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "name.basics",
                columns: table => new
                {
                    nconst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    primaryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthYear = table.Column<int>(type: "int", nullable: true),
                    deathYear = table.Column<int>(type: "int", nullable: true),
                    primaryProfession = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_name.basics", x => x.nconst);
                });

            migrationBuilder.CreateTable(
                name: "title.basics",
                columns: table => new
                {
                    tconst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    titleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    primaryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    originalTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startYear = table.Column<int>(type: "int", nullable: true),
                    runtimeMinutes = table.Column<int>(type: "int", nullable: true),
                    genres = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_title.basics", x => x.tconst);
                });

            migrationBuilder.CreateTable(
                name: "title.akas",
                columns: table => new
                {
                    titleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ordering = table.Column<byte>(type: "tinyint", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    region = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_title.akas", x => x.titleId);
                    table.ForeignKey(
                        name: "FK_title.akas_title.basics_titleId",
                        column: x => x.titleId,
                        principalTable: "title.basics",
                        principalColumn: "tconst",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "title.principals",
                columns: table => new
                {
                    tconst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nconst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ordering = table.Column<int>(type: "int", nullable: false),
                    category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_title.principals", x => new { x.tconst, x.nconst });
                    table.ForeignKey(
                        name: "FK_title.principals_name.basics_nconst",
                        column: x => x.nconst,
                        principalTable: "name.basics",
                        principalColumn: "nconst",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_title.principals_title.basics_tconst",
                        column: x => x.tconst,
                        principalTable: "title.basics",
                        principalColumn: "tconst",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "title.ratings",
                columns: table => new
                {
                    tconst = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    averageRating = table.Column<double>(type: "float", nullable: true),
                    numVotes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_title.ratings", x => x.tconst);
                    table.ForeignKey(
                        name: "FK_title.ratings_title.basics_tconst",
                        column: x => x.tconst,
                        principalTable: "title.basics",
                        principalColumn: "tconst",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_title.principals_nconst",
                table: "title.principals",
                column: "nconst");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "title.akas");

            migrationBuilder.DropTable(
                name: "title.principals");

            migrationBuilder.DropTable(
                name: "title.ratings");

            migrationBuilder.DropTable(
                name: "name.basics");

            migrationBuilder.DropTable(
                name: "title.basics");
        }
    }
}
