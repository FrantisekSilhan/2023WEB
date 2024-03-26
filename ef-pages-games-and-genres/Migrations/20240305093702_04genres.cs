using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ef_pages_games_and_genres.Migrations
{
    /// <inheritdoc />
    public partial class _04genres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Game_GamesGameId",
                table: "GameGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Genre_GenresGenreId",
                table: "GameGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameGenre",
                table: "GameGenre");

            migrationBuilder.DropIndex(
                name: "IX_GameGenre_GenresGenreId",
                table: "GameGenre");

            migrationBuilder.RenameColumn(
                name: "GenresGenreId",
                table: "GameGenre",
                newName: "GameGenreId");

            migrationBuilder.RenameColumn(
                name: "GamesGameId",
                table: "GameGenre",
                newName: "GenreId");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "GameGenre",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameGenre",
                table: "GameGenre",
                columns: new[] { "GameId", "GenreId" });

            migrationBuilder.InsertData(
                table: "GameGenre",
                columns: new[] { "GameId", "GenreId", "GameGenreId" },
                values: new object[,]
                {
                    { 1, 1, 0 },
                    { 1, 2, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameGenre_GameGenreId",
                table: "GameGenre",
                column: "GameGenreId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameGenre_GenreId",
                table: "GameGenre",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Game_GameId",
                table: "GameGenre",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Genre_GenreId",
                table: "GameGenre",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Game_GameId",
                table: "GameGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Genre_GenreId",
                table: "GameGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameGenre",
                table: "GameGenre");

            migrationBuilder.DropIndex(
                name: "IX_GameGenre_GameGenreId",
                table: "GameGenre");

            migrationBuilder.DropIndex(
                name: "IX_GameGenre_GenreId",
                table: "GameGenre");

            migrationBuilder.DeleteData(
                table: "GameGenre",
                keyColumns: new[] { "GameId", "GenreId" },
                keyColumnTypes: new[] { "INTEGER", "INTEGER" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "GameGenre",
                keyColumns: new[] { "GameId", "GenreId" },
                keyColumnTypes: new[] { "INTEGER", "INTEGER" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "GameGenre");

            migrationBuilder.RenameColumn(
                name: "GameGenreId",
                table: "GameGenre",
                newName: "GenresGenreId");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "GameGenre",
                newName: "GamesGameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameGenre",
                table: "GameGenre",
                columns: new[] { "GamesGameId", "GenresGenreId" });

            migrationBuilder.CreateIndex(
                name: "IX_GameGenre_GenresGenreId",
                table: "GameGenre",
                column: "GenresGenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Game_GamesGameId",
                table: "GameGenre",
                column: "GamesGameId",
                principalTable: "Game",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Genre_GenresGenreId",
                table: "GameGenre",
                column: "GenresGenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
