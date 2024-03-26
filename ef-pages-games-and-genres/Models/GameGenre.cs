using System.ComponentModel.DataAnnotations.Schema;

namespace ef_pages_games_and_genres.Models {
    public class GameGenre {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameGenreId { get; set; }
        [ForeignKey(nameof(GameId))]
        public int GameId { get; set; }
        public Game? Game { get; set; }
        [ForeignKey(nameof(GameId))]
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}
