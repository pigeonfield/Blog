using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class PostViewModel
    {
        public int PostId { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Content { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsPostofTheMonth { get; set; }

        public string CategoryName { get; set; }

        public PostViewModel()
        {       
        }

        public PostViewModel(Post post)
        {
            if (post == null)
                return;

            PostId = post.PostId;
            Title = post.Title;
            Date = post.Date;

            CategoryName = post.Category?.CategoryName;
        }
    }
}
