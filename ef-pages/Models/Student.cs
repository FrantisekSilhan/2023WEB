﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef_pages.Models {
	public class Student {
		public Guid StudentId { get; set; }
		[Required]
		[MinLength(2)]
		public string StudentName { get; set; } = string.Empty;
		public string? StudentEmail { get; set;}
		[Required]
		[ForeignKey(nameof(ClassId))]
		public Class? Class { get; set; }
		public int ClassId { get; set; }
	}
}
