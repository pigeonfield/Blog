using Blog.DAL.DAO;
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

        public ICollection<Comment> Comments { get; set; }
        
        public ICollection<Category> Category { get; set; }

        public Comment FormModel { get; set; } = new Comment();   //creating a new empty comment 

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
            Content = post.Content;
            ImageUrl = post.ImageUrl;
            ImageThumbnailUrl = post.ImageThumbnailUrl;
            IsPostofTheMonth = post.IsPostofTheMonth;

            Comments = post.Comments ?? new List<Comment>();

            FormModel.Post = post;

            CategoryName = post.Category?.CategoryName;
        }




        public class CommentViewModel
        {
            public CommentViewModel()
            {

            }

            public CommentViewModel(Comment comment)
            {
                Comment = comment;
            }

            public Comment Comment { get; set; }
            public DateTime CommentDate { get; set; }
            public string CommentContent { get; set; }
            public string CommentAuthor { get; set; }
        }


    }
}
