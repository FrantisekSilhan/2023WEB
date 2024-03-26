using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ef_pages_games_and_genres.Data;
using ef_pages_games_and_genres.Models;

namespace ef_pages_games_and_genres.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly ef_pages_games_and_genres.Data.gameDbContext _context;

        public IndexModel(ef_pages_games_and_genres.Data.gameDbContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
