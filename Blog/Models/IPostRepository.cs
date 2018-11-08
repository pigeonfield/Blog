using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public interface IPostRepository
    {
        IEnumerable<Post> GetPosts();
        IEnumerable<Post> PostsOfTheMonth();
        IEnumerable<Post> RandomPosts();

        Post GetPostById(int postId);
    }
}
