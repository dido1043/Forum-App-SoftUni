using System.ComponentModel.DataAnnotations;

namespace ForumApp.Core.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Content { get; set; } = null!;
    }
}
