using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.DB.Entities.DataContext;
using Week3.Model;
using Week3.Model.User;

namespace Week3.Service.Job
{
    public class WelcomeJob : IWelcomeJob
    {

        public void PrintWelcome()
        {
            Console.WriteLine($"Hangfire recurring job");
        }

        
        public void SendEmail()
        {
            var result = new General<UserViewModel>();
            using (var context = new GrootContext())
            {
                var users = context.User.Where(x => x.IsActive &&!x.IsDeleted && !x.IsSendEmail).OrderBy(x => x.Id);

                foreach (var user in users)
                {
                    var message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Groot", "tkemiksiz@gmail.com"));
                    message.To.Add(new MailboxAddress("User", user.Email));
                    message.Subject = "Welcome to the Market";
                    message.Body = new TextPart("plain")
                    {
                        Text = user.Name + ", Welcome To the Market!"
                    };

                    using (var client = new SmtpClient())
                    {
                        client.Connect("smtp@gmail.com", 587, false);
                        client.Authenticate("tkemiksiz@gmail.com", "123456asd");
                        client.Send(message);
                        client.Disconnect(true);
                    }

                    user.IsSendEmail = true;
                    context.SaveChanges();


                }
            }



        }

    }
}
