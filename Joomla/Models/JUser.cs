using Microsoft.AspNetCore.Identity;

namespace Joomla.Models {
    public class JUser : IdentityUser<Guid> {
        public string? FullName { get; set; } = default!;
        public DateTime? BirthDate { get; set; } = default!;

        public ICollection<Article> Articles { get; set; } = default!;
    }
}
