using ef_pages_games_and_genres.Models;

using Microsoft.EntityFrameworkCore;

namespace ef_pages_games_and_genres.Data {
    public class gameDbContext(DbContextOptions options) : DbContext(options) {
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<GameGenre>()
                .HasIndex(x => x.GameGenreId).IsUnique();
            modelBuilder.Entity<GameGenre>()
                .HasKey(gg => new { gg.GameId, gg.GenreId });

            Genre shooter = new Genre { GenreId = 1, Name = "Shooter" };
            Genre rpg = new Genre { GenreId = 2, Name = "RPG" };
            Genre puzzle = new Genre { GenreId = 3, Name = "Puzzle" };
            modelBuilder.Entity<Genre>(g => {
                g.HasData(
                   shooter,
                   rpg,
                   puzzle
                );
            });

            ICollection<Genre> genres = new List<Genre> { shooter, rpg, puzzle };

            modelBuilder.Entity<Game>(g => {
                g.HasData(
                    new Game { GameId = 1, Name = "Doom" },
                    new Game { GameId = 2, Name = "Quake" },
                    new Game { GameId = 3, Name = "Final Fantasy" },
                    new Game { GameId = 4, Name = "Baldur's Gate" },
                    new Game { GameId = 5, Name = "Tetris" },
                    new Game { GameId = 6, Name = "Bejeweled" }
                );
            });

            modelBuilder.Entity<GameGenre>(gg => {
                gg.HasData(
                    new GameGenre { GameId = 1, GenreId = 1 },
                    new GameGenre { GameId = 1, GenreId = 2 }
                );
            });
        }
        public DbSet<ef_pages_games_and_genres.Models.Game> Game { get; set; } = default!;
    }
}
