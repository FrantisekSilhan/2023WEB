using _190923WEB.InputModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _190923WEB.Pages.Data
{
    public class IndexModel : PageModel
    {
        public string Text { get; set; } = string.Empty;
        [BindProperty]
        public RegistraceIM Registrace { get; set; } = new RegistraceIM();

        public void OnGet()
        {
            // OnGet
        }
        public void OnGetText(string text, int? kolik)
        {
            Text = text + " " + (kolik * 2);
        }

        //page handler = Cisla
        public void OnGetCisla(int cislo)
        {
            Text = string.Format("Číslo je {0}", cislo);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("/Index", new { text = "Ahoj" });
            }

            return Page();
        }
    }
}
