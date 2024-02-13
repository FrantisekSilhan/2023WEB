using System.ComponentModel.DataAnnotations;

namespace ef_pages.Models {
	public class Class {
		public int ClassId { get; set; }
		[Required]
		public string Name { get; set; } = string.Empty;
		public required ICollection<Student> Students { get; set; }
	}
}
