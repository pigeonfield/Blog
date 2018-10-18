using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BlogController(IPostRepository postRepository, ICategoryRepository categoryRepository)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
        }

       
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet("posts")]
        public IActionResult Posts()
        {
            PostsListViewModel postsListViewModel = new PostsListViewModel();
            postsListViewModel.Posts = _postRepository.Posts;

            postsListViewModel.CurrentCategory = "Europe";
            return View(postsListViewModel);
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}