using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.utils
{
    public class PasswordUils
    {
        public static string HashingPassword(string password)
        {
            int salt = 12;
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
        }

        public static bool ComparePassword(string nativePassword, string hashPassword)
        {
            return BCrypt.Net.BCrypt.Verify(nativePassword, hashPassword);
        }
    }
}
