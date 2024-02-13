using System.ComponentModel.DataAnnotations;

namespace ef_pages.Models {
	public class Subject {
		public int SubjectId { get; set; }
		[Required]
		[StringLength(4)]
		public string SubjectShortName { get; set; } = string.Empty;
		[Required]
		public string SubjectName { get; set; } = string.Empty;
	}
}
