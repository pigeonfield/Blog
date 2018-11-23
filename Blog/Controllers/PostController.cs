using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.BL;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("[controller]")]
    public class PostController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPostRepository _postRepository;

        private readonly IPostModel _postModel;

        public PostController(IPostModel postModel, ICategoryRepository categoryRepository, IPostRepository postRepository)
        {
            _postModel = postModel;
            _categoryRepository = categoryRepository;
            _postRepository = postRepository;
        }



        [HttpGet("show/{postId}")]
        public IActionResult Show(int postId)
        {
            if (postId <= 0)
                return BadRequest("Invalid postId");
            
            var post = _postModel.GetPostById(postId);

            if (post == null)
                return NotFound("Post not found");

            ShowRandomPost();

            return View(post);
        }

        private void ShowRandomPost()
        {
            var randomposts = _postRepository.RandomPosts();
            ViewBag.RandomPosts = randomposts;
        }


        public IActionResult Create()
        {
            return null;
        }

        public IActionResult Edit(int postId)
        {
            return null;
        }

        public IActionResult Delete(int postId)
        {
            return null;
        }
    }
}