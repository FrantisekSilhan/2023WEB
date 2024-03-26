using Joomla.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Joomla.Data {
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<JUser, IdentityRole<Guid>, Guid>(options) {

        public DbSet<Article> Articles { get; set; }
        public DbSet<JUser> JUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.Entity<JUser>().ToTable("Users");
            builder.Entity<JUser>().Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Entity<Article>().Property(a => a.CreatedAt).HasDefaultValue(DateTime.UtcNow);
        }
    }
}
