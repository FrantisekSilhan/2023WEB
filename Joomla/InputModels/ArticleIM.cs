using System.ComponentModel.DataAnnotations;

namespace Joomla.InputModels {
    public class ArticleIM {
        [Required]
        public string Title { get; set; } = default!;
        [Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; } = default!;
    }
}
