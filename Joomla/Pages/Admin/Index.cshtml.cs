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
    public class IndexModel : PageModel
    {
        private readonly Joomla.Data.ApplicationDbContext _context;

        public IndexModel(Joomla.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<JUser> JUser { get;set; } = default!;

        public async Task OnGetAsync()
        {
            JUser = await _context.JUsers.ToListAsync();
        }
    }
}
