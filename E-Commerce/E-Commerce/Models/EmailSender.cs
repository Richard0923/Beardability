using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class EmailSender : IEmailSender 
    {
        public IConfiguration Configuration { get; }

        public EmailSender(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            SendGridClient client = new SendGridClient(Configuration["SendGridKey"]);

            SendGridMessage msg = new SendGridMessage();

            msg.SetFrom("Admin@beardsrus.com", "Admin");
            msg.AddTo(email);
            msg.SetSubject(subject);
            msg.AddContent(MimeType.Html, htmlMessage);
                
            await client.SendEmailAsync(msg);
        }


    }
}
