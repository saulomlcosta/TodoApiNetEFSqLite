using System.ComponentModel.DataAnnotations;

namespace MyTodoApi.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]  
        public string Title { get; set; }
    }
}
