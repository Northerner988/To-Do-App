using System;
using Microsoft.EntityFrameworkCore;
using ToDoListApp.Models;


namespace ToDoListApp.Data
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext(DbContextOptions<ToDoListContext> options) : base(options)
        {
        }

        public DbSet<ToDoTask> ToDoTasks { get; set; } = default!;
    }
}