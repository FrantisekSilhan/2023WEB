using ef_pages.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_pages.Data {
	public class SchoolDbContext(DbContextOptions options) : DbContext(options) {
		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Class> Classes { get; set; }
		public DbSet<Student> students { get; set; }
		public DbSet<Subject> subjects { get; set; }
		public DbSet<SubjectOnClass> subjectOnClasses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			//base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<SubjectOnClass>()
				.HasIndex(x => x.SubjectOnClassId).IsUnique();
			modelBuilder.Entity<SubjectOnClass>()
				.HasKey(soc => new { soc.ClassId, soc.SubjectId });
			modelBuilder.Entity<Class>(c => {
				c.HasData(
					new Class { ClassId = 1, ClassName = "P3A" },
					new Class { ClassId = 2, ClassName = "P4" }
				);
			});
			modelBuilder.Entity<Student>(s => {
				s.HasData(
					new Student { StudentId = Guid.NewGuid(), StudentName = "Franta Vomáčka", ClassId = 1  },
					new Student { StudentId = Guid.NewGuid(), StudentName = "Alice", ClassId = 1  },
					new Student { StudentId = Guid.NewGuid(), StudentName = "Bob", ClassId = 2  }
				);
			});
			modelBuilder.Entity<Subject>(s => {
				s.HasData(
					new Subject { SubjectId = 1, SubjectShortName = "MAT", SubjectName = "Matematika" },
					new Subject { SubjectId = 2, SubjectShortName = "ANJ", SubjectName = "Angličtina" },
					new Subject { SubjectId = 3, SubjectShortName = "WEB", SubjectName = "Webové aplikace" },
					new Subject { SubjectId = 4, SubjectShortName = "PRG", SubjectName = "Programování" }
				);
			});

			modelBuilder.Entity<Teacher>(t => {
				t.HasData(
					new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Ozzy Matikář" },
					new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Jan Butanský" },
					new Teacher { TeacherId = Guid.NewGuid(), TeacherName = "Petr Mucha" }
				);
			});
			/*modelBuilder.Entity<SubjectOnClass>(soc => {
				soc.HasData(
					new SubjectOnClass { ClassId = 1, SubjectId = 1, TeacherId =  },
					new SubjectOnClass { ClassId = 1, SubjectId = 2, TeacherId =  },
					new SubjectOnClass { ClassId = 1, SubjectId = 3, TeacherId =  },
					new SubjectOnClass { ClassId = 1, SubjectId = 4, TeacherId = }

                );
			});*/
		}
	}
}
