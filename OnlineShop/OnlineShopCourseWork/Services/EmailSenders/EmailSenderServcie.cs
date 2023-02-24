using System.Net;
using System.Net.Mail;
using System.Text;

namespace OnlineShopCourseWork.Services.EmailSenders
{
    public sealed class EmailSenderServcie : IEmailSenderService
    {
        const string HostName = @"smtp.mail.com";
        const int HostPort = 587;
        const string Username = "mycustombotsender@mail.com";
        const string Password = "aA12345678.";

        public void SendEmail(string email)
        {
            try
            {
                NetworkCredential credentials = new(Username, Password);
                SmtpClient client = new()
                {
                    Port = HostPort,
                    Host = HostName,
                    Credentials = credentials,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                };
                
                //client.UseDefaultCredentials = false;
                
                //client.Credentials = credentials;

                MailAddress from = new MailAddress("mycustombotsender@mail.com", "sender");
                MailAddress to = new MailAddress("dimcando@gmail.com", "dimcando");

                MailMessage myMail = new MailMessage(from, to);

                MailAddress replyTo = new MailAddress("mycustombotsender@mail.com");
                myMail.ReplyToList.Add(replyTo);

                myMail.Subject = "Testing my mail sender bot!";
                myMail.SubjectEncoding = Encoding.UTF8;

                myMail.Body = "Hello, I am testing my sender bot!";
                myMail.BodyEncoding = Encoding.UTF8;

                client.Send(myMail);

            }
            catch (SmtpException ex) 
            {

            }
            catch (Exception ex)
            {

                throw;
            }

            
            throw new NotImplementedException();
        }
    }
}
