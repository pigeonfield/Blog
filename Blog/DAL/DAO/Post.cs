using Blog.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsPostofTheMonth { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
