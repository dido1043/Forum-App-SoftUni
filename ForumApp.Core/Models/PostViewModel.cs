using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.Core.Models
{
    public class PostViewModel
    {

        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
    }
}
