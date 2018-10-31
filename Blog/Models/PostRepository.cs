﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class PostRepository: IPostRepository
    {

        private readonly AppDbContext _appDbContext; 

        public PostRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext; 
        }

        public IEnumerable<Post> Posts
        {
            get
            {
                return _appDbContext.Posts.Include(c => c.Category);
            }

        }


        public IEnumerable<Post> PostsOfTheMonth
        {
            get
            {
                return _appDbContext.Posts.Include(c => c.Category).Where(p => p.IsPostofTheMonth);
            }

        }

        public Post GetPostById(int postId)
        {
            return _appDbContext.Posts.FirstOrDefault(p => p.PostId == postId);
        }
    }
}
