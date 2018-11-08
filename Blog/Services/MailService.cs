using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class MailService : IMailService
    {

        public async Task Send(Message msg)
        {
            using (var smtp = new SmtpClient())
            {
                smtp.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                smtp.PickupDirectoryLocation = "alexandra12@wp.pl";

                var message = new MailMessage
                {
                    Body = msg.MessageContent,
                    Subject = msg.MessageTitle,
                    From = new MailAddress(msg.Email)
                };
                message.To.Add("alexandra12@wp.pl");

                await smtp.SendMailAsync(message);

                
            }

            
        }


    }
}
