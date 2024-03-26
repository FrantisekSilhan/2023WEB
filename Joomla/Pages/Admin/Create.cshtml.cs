using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Joomla.Data;
using Joomla.Models;

namespace Joomla.Pages.Admin
{
    public class CreateModel : PageModel
    {
        private readonly Joomla.Data.ApplicationDbContext _context;

        public CreateModel(Joomla.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JUser JUser { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JUsers.Add(JUser);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
