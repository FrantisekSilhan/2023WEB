using System.ComponentModel.DataAnnotations;

namespace ef_pages_games_and_genres.Models {
    public class Game {
        public int GameId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public ICollection<GameGenre>? GameGenres { get; set; }
    }
}
