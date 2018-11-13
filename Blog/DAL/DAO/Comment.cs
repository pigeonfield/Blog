using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAL.DAO
{
    public class Comment
    {
        public int CommentId { get; set; }
        public virtual Post Post { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentAuthor { get; set; }
        public string CommentContent { get; set; }

    }
}
