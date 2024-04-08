using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Joomla.Data;
using Joomla.Models;
using Joomla.InputModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Joomla.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly Joomla.Data.ApplicationDbContext _context;
        private readonly UserManager<JUser> _users;

        public CreateModel(Joomla.Data.ApplicationDbContext context, UserManager<JUser> users)
        {
            _context = context;
            _users = users;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthorId"] = new SelectList(_context.JUsers, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public ArticleIM ArticleIM { get; set; } = new ArticleIM();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            Article article = new Article {
                Title = ArticleIM.Title,
                Content = ArticleIM.Content,
                Author = (await _users.GetUserAsync(User))!,
                CreatedAt = DateTime.Now
            };

            await _context.Articles.AddAsync(article);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Articles/Index");
        }
    }
}
