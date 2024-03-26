using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Joomla.Data;
using Joomla.Models;

namespace Joomla.Pages.Admin
{
    public class EditModel : PageModel
    {
        private readonly Joomla.Data.ApplicationDbContext _context;

        public EditModel(Joomla.Data.ApplicationDbContext context)
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

            var juser =  await _context.JUsers.FirstOrDefaultAsync(m => m.Id == id);
            if (juser == null)
            {
                return NotFound();
            }
            JUser = juser;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(JUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JUserExists(JUser.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool JUserExists(Guid id)
        {
            return _context.JUsers.Any(e => e.Id == id);
        }
    }
}
