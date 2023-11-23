using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDoTask
   {
      public int Id { get; set; }
        [Required,StringLength(50, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 50 characters.")]
        public string Title { get; set; } = string.Empty;

     
        [Required, StringLength(300, MinimumLength=3 ,ErrorMessage = "Description must be between 3 and 300 characters.")]
        public string Description { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please select a date.")]
        public DateTime SelectDate { get; set; }
}
}
