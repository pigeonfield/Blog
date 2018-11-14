﻿using Blog.DAL.DAO;
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
    }
}
