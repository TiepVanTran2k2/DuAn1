using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QuanLy
{
    public static class IsValidEmail
    {
        public static bool ValidEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
