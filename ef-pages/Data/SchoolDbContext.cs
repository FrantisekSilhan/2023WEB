using ef_pages.Models;
using Microsoft.EntityFrameworkCore;

namespace ef_pages.Data {
	public class SchoolDbContext : DbContext {
		public SchoolDbContext(DbContextOptions options) : base(options) {

		}
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
		}
	}
}
