using Blog.Models;
using Blog.ViewModels;

namespace Blog.BL
{
    public class PostModel : IPostModel
    {
        private readonly IPostRepository _postRepository;

        public PostModel(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public PostViewModel GetPostById(int postId)
        {
            var post = _postRepository.GetPostById(postId);

            if (post == null)
                return null;

            return new PostViewModel(post);
        }

        public PostViewModel GetPosts()
        {

        }
    }
}
