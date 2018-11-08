using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("[controller]")]
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PostController(IPostRepository postRepository, ICategoryRepository categoryRepository)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
        }

        //public IActionResult Create()
        //{
        //    return 
        //}

        [HttpGet("show/{postId}")]
        public IActionResult Show(int postId)
        {
            if (postId <= 0)
            {
                return BadRequest("Invalid postId");
            }

            var post = _postRepository.GetPostById(postId);
            if (post == null)
            {
                return NotFound("No such post");
            }

            var postVM = new PostViewModel(post);

            ShowRandomPost();

            return View(postVM);
        }

        private void ShowRandomPost()
        {
            var randomposts = _postRepository.RandomPosts();
            ViewBag.RandomPosts = randomposts;
        }
    }
}