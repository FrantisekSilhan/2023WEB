using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Joomla.Data;
using Joomla.Models;

namespace Joomla.Pages.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly Joomla.Data.ApplicationDbContext _context;

        public DeleteModel(Joomla.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public JUser JUser { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juser = await _context.JUsers.FirstOrDefaultAsync(m => m.Id == id);

            if (juser == null)
            {
                return NotFound();
            }
            else
            {
                JUser = juser;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juser = await _context.JUsers.FindAsync(id);
            if (juser != null)
            {
                JUser = juser;
                _context.JUsers.Remove(JUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
