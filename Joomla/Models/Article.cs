using System.ComponentModel.DataAnnotations.Schema;

namespace Joomla.Models {
    public class Article {
        public int Id { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Content { get; set; } = default!;
        public DateTime CreatedAt { get; set; } = default!;
        public Guid AuthorId { get; set; } = default!;
        [ForeignKey(nameof(AuthorId))]
        public JUser Author { get; set; } = default!;
    }
}
