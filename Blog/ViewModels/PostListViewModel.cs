using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels
{
    public class PostsListViewModel
    {
        public IEnumerable<Post> Posts { get; set; }

       
    }
}
