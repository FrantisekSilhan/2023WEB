using ef_pages.Data;
using ef_pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ef_pages.Pages {
	public class IndexModel : PageModel {
		private readonly ILogger<IndexModel> _logger;
		private readonly SchoolDbContext _ctx;
		public IEnumerable<Class> ClassesE { get; set; }
		public IList<Class> ClassesL { get; set; }

		public IndexModel(ILogger<IndexModel> logger, SchoolDbContext schoolDbContext) {
			_logger = logger;
			_ctx = schoolDbContext;
		}

		public void OnGet() {
			ClassesL = _ctx.Classes.Take(10).ToList();
			ClassesE = _ctx.Classes.Include(c => c.Students).AsEnumerable();
		}
	}
}
