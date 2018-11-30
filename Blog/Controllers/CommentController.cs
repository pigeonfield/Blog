using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Blog.DAL.DAO;
using Blog.DAL.Repositories;
using Blog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Blog.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class CommentController : Controller
    {
        AppDbContext db = new AppDbContext();

        private readonly ICommentRepository _commentRepository;
       

        public CommentController(ICommentRepository commentRepository)
        {

            _commentRepository = commentRepository;
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int id, Comment comment)
        {
            if (id < 1)
            {
                return BadRequest("Error");
            }

            Comment savedComment = null;
            if (ModelState.IsValid)
            {
                comment.CommentDate = DateTime.UtcNow;
                savedComment = _commentRepository.AddComment(comment, id);
            }

            else
            {
                return BadRequest("Wrong input data");
            }

            if (savedComment == null)
            {
                return BadRequest("Post with provided Id doesn't exists");
            }

            return RedirectToAction("Show", "Post", new RouteValueDictionary { { "postId", savedComment.Post.PostId } });
        }


        [HttpGet("Delete")]
        public ActionResult Delete(int commentId, int postId)
        {
            if (commentId < 1)
            {
                return BadRequest("comment with this id doesn't exist");
            }

            _commentRepository.DeleteComment(commentId);
            return RedirectToAction("Show", "Post", new { postId = postId } );
            
        }


    }
}