using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SessionServiceToDo.Models;

using SessionServiceToDo.Services;
using System.ComponentModel.DataAnnotations;

namespace SessionServiceToDo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ToDoService _toDoService;
        public IEnumerable<ToDo> ToDoList { get; set; }

        [Required(ErrorMessage = "Je třeba vložit text úkolu...")]
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public IndexModel(ILogger<IndexModel> logger, ToDoService toDoService)
        {
            _logger = logger;
            _toDoService = toDoService;
            ToDoList = _toDoService.GetAll();
        }

        public void OnGetAdd()
        {
            if (ModelState.IsValid)
            {
                ToDoList = _toDoService.GetAll() ?? new List<ToDo>();
                _toDoService.AddToDo(Name);
            }
        }

        public void OnGet()
        {
        }
    }
}