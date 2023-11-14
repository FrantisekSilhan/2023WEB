using CookieMaker2023P3A.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CookieMaker2023P3A.Pages
{
    public class TempDataSetterModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Text { get; set; } = string.Empty;
        private readonly string _key;
        public TempDataSetterModel(IConfiguration configuration)
        {
            _key = configuration["TempDataKey"];
        }
        public void OnGet()
        {
            TempData.AddMessage(_key, TempDataExtension.MessageType.warning, "Byli jsme na stránce");
        }

        public void OnGetSetName()
        {
            TempData.AddMessage(_key, TempDataExtension.MessageType.success, Text);
        }
    }
}
