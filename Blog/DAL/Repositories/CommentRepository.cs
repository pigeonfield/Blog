using Blog.DAL.DAO;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAL.Repositories
{
    public class CommentRepository : ICommentRepository
    {

        private readonly AppDbContext _appDbContext;   //access to appdbcontext 

        public CommentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Comment GetCommentById(int commentId)     
        {
            return _appDbContext.Comments.Include(p => p.Post).FirstOrDefault(c => c.CommentId == commentId);
        }

        public IEnumerable<Comment> GetComments()
        {
            return _appDbContext.Comments.Include(p => p.Post);
        }

        public Comment AddComment(Comment comment)
        {
            _appDbContext.Comments.Add(comment);
            _appDbContext.SaveChanges();

            return comment;
        }

        public Comment AddComment(Comment comment, int postId)
        {
            var post = _appDbContext.Posts.FirstOrDefault(p => p.PostId == postId);

            if (post == null)
                return null;

            comment.Post = post;
            return AddComment(comment);
        }

        public Comment DeleteComment(Comment comment, int comId)
        {
            var comm = _appDbContext.Comments.FirstOrDefault(p => p.CommentId == comId);

            if (comm != null)
            {
                _appDbContext.Comments.RemoveRange(comm);
                _appDbContext.SaveChanges();
            }
            
            
            return null;
        }
    }
}
