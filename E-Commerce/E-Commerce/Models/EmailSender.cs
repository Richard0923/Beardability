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
    /// <summary>
    /// Gives us the functionallity to be able to send emails to the user
    /// </summary>
    public class EmailSender : IEmailSender 
    {
        public IConfiguration Configuration { get; }

        public EmailSender(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Method that allows us to send the user an email
        /// </summary>
        /// <param name="email">Users email</param>
        /// <param name="subject">Subject string </param>
        /// <param name="htmlMessage">Message but needs to be in html format</param>
        /// <returns></returns>
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
