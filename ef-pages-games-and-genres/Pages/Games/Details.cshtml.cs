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
    public class DetailsModel : PageModel
    {
        private readonly ef_pages_games_and_genres.Data.gameDbContext _context;

        public DetailsModel(ef_pages_games_and_genres.Data.gameDbContext context)
        {
            _context = context;
        }

        public Game Game { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game.FirstOrDefaultAsync(m => m.GameId == id);
            if (game == null)
            {
                return NotFound();
            }
            else
            {
                Game = game;
            }
            return Page();
        }
    }
}
