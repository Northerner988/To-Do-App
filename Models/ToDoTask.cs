using System.ComponentModel.DataAnnotations;

namespace ToDoListApp.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime SelectDate { get; set; }
    }
}
