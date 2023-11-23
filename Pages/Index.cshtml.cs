using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models;
using ToDoListApp.Data;



namespace ToDoList.Pages;

public class IndexModel : PageModel
{
   private readonly ToDoListApp.Data.ToDoListContext _context;

    public IndexModel(ToDoListApp.Data.ToDoListContext context)
    {
        _context = context;
    }

    public IList<ToDoTask> ToDoTask { get;set; } = default!;

    public async Task OnGetAsync()
    {
        ToDoTask = await _context.ToDoTasks.ToListAsync();
    }
}


   

