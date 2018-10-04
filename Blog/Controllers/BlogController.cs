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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Posts()
        {
            PostsListViewModel postsListViewModel = new PostsListViewModel();
            postsListViewModel.Posts = _postRepository.Posts;

            postsListViewModel.CurrentCategory = "Europe";
            return View(postsListViewModel);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}