using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace ForumApp.Infrastructure.Data.Models
{
    public class Post
    {
        [Key]
        [Comment("Post ID")]
        public int Id { get; set; }


        [Required]
        [Comment("Post title")]
        [MaxLength(Constants.Constants.TitleMaxLength)]
        [MinLength(Constants.Constants.TitleMinLength)]
        public string Title { get; set; } = null!;

        [Required]
        [Comment("Post content")]
        [MaxLength(Constants.Constants.ContentMaxLength)]
        public string Content { get; set; } = null!;
    }
}
