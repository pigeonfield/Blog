using Blog.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetComments();  
        
        Comment GetCommentById(int commentId);

        Comment AddComment(Comment comment);

        Comment AddComment(Comment comment, int postId);

        Comment DeleteComment(Comment comment, int commentId);
    }
}
