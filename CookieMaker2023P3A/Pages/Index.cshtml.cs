using CookieMaker2023P3A.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieMaker2023P3A.Pages
{
    public class IndexModel : PageModel
    {
        [TempData]
        public string Name { get; set; }
        public int LastRoll { get; set; }
        public string LastAccess { get; set; }

        private readonly ILogger<IndexModel> _logger;
        private readonly IDice _dice;

        public readonly string Key;


        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration, IDice dice)
        {
            _logger = logger;
            _dice = dice;
            Key = configuration["TempDataKey"];
        }

        public void OnGet()
        {
            LastRoll = _dice.LastRoll;
            LastAccess = Request.Cookies["lastaccess"] ?? DateTime.Now.ToString();
            Response.Cookies.Append("lastaccess", DateTime.Now.ToString(), new CookieOptions
            {
                Expires = DateTime.Now.AddDays(1),
                Secure = true
            });
        }

        public void OnGetRoll()
        {
            _dice.Roll();
            LastRoll = _dice.LastRoll;
        }
    }
}