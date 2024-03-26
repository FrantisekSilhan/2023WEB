using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef_pages.Models {
	public class Teacher {
		[Key]
		public Guid TeacherId {  get; set; }
		[Required]
		[StringLength(50)]
		public string TeacherName { get; set; } = string.Empty;
		public ICollection<SubjectOnClass>? subjectOnClasses { get; set; }

		[ForeignKey(nameof(MentorId))]
		public Teacher? Mentor { get; set; }
		public Guid? MentorId { get; set; }
	}
}
