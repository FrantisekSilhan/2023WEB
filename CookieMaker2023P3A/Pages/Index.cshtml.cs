using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieMaker2023P3A.Pages
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Name { get; set; }
        public string LastAccess { get; set; }

        private readonly ILogger<IndexModel> _logger;
        public readonly string Key;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            Key = configuration["TempDataKey"];
        }

        public void OnGet()
        {
            LastAccess = Request.Cookies["lastaccess"] ?? DateTime.Now.ToString();
            Response.Cookies.Append("lastaccess", DateTime.Now.ToString(), new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1),
                Secure = true
            });
        }
    }
}