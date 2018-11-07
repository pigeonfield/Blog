using Blog.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Contact
{
    public class ContactModel
    {
        private readonly IMailService _mailSender;

        public ContactModel(IMailService mailSender)
        {
            _mailSender = mailSender;
        }

        public string Welcome { get; set; }

        [BindProperty]
        public Message Message { get; set; }

        public async Task OnPost()
        {
            await _mailSender.Send(Message);
        }
    }
}
