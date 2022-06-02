using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class AutoEmail
    {
        public void send_mail(string email, string systeemNaam, string foutmelding)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("test05182022@gmail.com");

                mail.To.Add(email);
                mail.Subject = "Er is een fout in: " + systeemNaam;
                mail.Body = "In systeem: " + systeemNaam + " is de volgende fout gevonden: " + foutmelding;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("test05182022@gmail.com", "tgnffwunwudseqll");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Console.WriteLine("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
