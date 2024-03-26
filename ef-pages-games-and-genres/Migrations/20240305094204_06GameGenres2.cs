using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ef_pages_games_and_genres.Migrations
{
    /// <inheritdoc />
    public partial class _06GameGenres2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GameGenre",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1, 1 },
                column: "GameGenreId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "GameGenre",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1, 2 },
                column: "GameGenreId",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GameGenre",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1, 1 },
                column: "GameGenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "GameGenre",
                keyColumns: new[] { "GameId", "GenreId" },
                keyValues: new object[] { 1, 2 },
                column: "GameGenreId",
                value: 2);
        }
    }
}
