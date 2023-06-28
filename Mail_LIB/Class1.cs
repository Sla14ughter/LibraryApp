using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Mail_LIB
{
    public class Mail
    {
        public static bool CheckMail(string mail)
        {
            return Regex.IsMatch(mail, @"^(?!.*[QqIi].*)(?!.{21,})(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)$");
        }
        public static string GetMail(string mail)
        {
            Random rnd = new Random();
            return mail.Insert(mail.IndexOf('@'), $"{(char)('a' + rnd.Next(0, 26))}");
        }
    }
}
