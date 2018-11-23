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
        public IActionResult Contact(Message contactMessage)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("MessageSent");
            }
            return View(contactMessage);
        }

        public IActionResult MessageSent()
        {
            return View();
        }
    }
}