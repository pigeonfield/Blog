using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public interface IPostRepository
    {
        IEnumerable<Post> Posts { get; }
        IEnumerable<Post> PostsOfTheMonth { get; }

        Post GetPostById(int postId);
    }
}
