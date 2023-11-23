using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ToDoList.Models;
using ToDoListApp.Data;

namespace ToDoList.Pages_Tasks
{
    public class AddTaskModel : PageModel
    {
        private readonly ToDoListApp.Data.ToDoListContext _context;

        public AddTaskModel(ToDoListApp.Data.ToDoListContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ToDoTask ToDoTask { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ToDoTasks.Add(ToDoTask);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Index");
        }
    }
}