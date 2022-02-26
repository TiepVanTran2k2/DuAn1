using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public static class BUS_SendGmail
    {
        public static bool SendMail(string email, string subject, string body)
        {
            try 
            {
                var fromAddress = new MailAddress("trasuaqlmeta@gmail.com");
                var toAddress = new MailAddress(email);
                const string fromPassword = "fm2fD89V";
    
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
           
    }
}
