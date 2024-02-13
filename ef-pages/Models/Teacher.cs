using System.ComponentModel.DataAnnotations;

namespace ef_pages.Models {
	public class Teacher {
		[Key]
		public Guid TeacherId {  get; set; }
		[Required]
		[StringLength(50)]
		public string TeacherName { get; set; } = string.Empty;
	}
}
