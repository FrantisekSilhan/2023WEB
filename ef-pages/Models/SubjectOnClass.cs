using System.ComponentModel.DataAnnotations.Schema;

namespace ef_pages.Models {
	public class SubjectOnClass {
		public int SubjectOnClassId { get; set; }

		[ForeignKey(nameof(ClassId))]
		public required Class Class { get; set; }
		public int ClassId { get; set; }

		[ForeignKey(nameof(SubjectId))]
		public required Subject Subject { get; set; }
		public int SubjectId { get; set; }
	}
}
