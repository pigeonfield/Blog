using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.DAL.DAO;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("[controller]")]
    public class CommentController : Controller
    {
        AppDbContext db = new AppDbContext();

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            db.Comments.Add(comment);     //add comment to database
            db.SaveChanges();              //saving database
            return RedirectToAction("Show", "Post");  //redirecting to current post page
        }

        //public IActionResult Edit()
        //{
        //    return View();
        //}

        //public IActionResult Delete()
        //{
        //    return View();
        //}


    }
}