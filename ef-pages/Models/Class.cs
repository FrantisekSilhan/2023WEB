using System.ComponentModel.DataAnnotations;

namespace ef_pages.Models {
	public class Class {
		public int ClassId { get; set; }
		[Required]
		public string ClassName { get; set; } = string.Empty;
		public ICollection<Student>? Students { get; set; }
		public ICollection<SubjectOnClass>? subjectOnClasses { get; set; }

		public ICollection<Subject>? Subjects2 { get; set; }
	}
}
