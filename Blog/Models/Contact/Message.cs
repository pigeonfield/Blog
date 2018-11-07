using Blog.Models.Enums;
using Blog.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Message
    {
        //private readonly IMailService _mailService;

        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, MinimumLength = 4)]
        public string Sender { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public MsgCategoryType MessageCategory { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string MessageTitle { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [StringLength(200, MinimumLength = 30)]
        public string MessageContent { get; set; }
    }

}
