using Blog.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAL.DAO
{
    public class Comment
    {
        public int CommentId { get; set; }
        public virtual Post Post { get; set; }
        public DateTime CommentDate { get; set; }
        [Required]
        public string CommentAuthor { get; set; }
        [Required]
        public string CommentContent { get; set; }
    }
}
