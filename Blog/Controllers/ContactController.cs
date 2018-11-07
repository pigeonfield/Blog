using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using MailKit.Net.Smtp;
using MimeKit;
using Blog.Services;

namespace Blog.Controllers
{
    public class ContactController : Controller
    {
               

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }


        [HttpPost("contact")]
        public ActionResult Contact(Message contactMessage)
        {
            return View("SendForm", contactMessage);
        }
    }
}