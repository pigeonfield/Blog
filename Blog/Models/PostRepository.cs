﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _appDbContext;

        public PostRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Post GetPostById(int postId)
        {
            return _appDbContext.Posts.Include(c => c.Category).FirstOrDefault(p => p.PostId == postId);
        }

        public IEnumerable<Post> GetPosts()
            => _appDbContext.Posts.Include(c => c.Category);
        
        IEnumerable<Post> IPostRepository.PostsOfTheMonth()
        {
            return _appDbContext.Posts.Include(c => c.Category).Where(p => p.IsPostofTheMonth);
        }

        public IEnumerable<Post> RandomPosts()
        {
            var randomPosts = _appDbContext.Posts.Include(c => c.Category).OrderBy(r => Guid.NewGuid()).Take(3);
            
            return randomPosts;             
        }

        
    }
}
