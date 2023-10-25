using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace quan_ly_resort_v2.model
{
    public class Account
    {
        private string username;
        private string password;
        private DateTime create_at;

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Account(Account account)
        {
            this.username = account.username;
            this.password = account.password;
        }

        public string Username
        {
            get { return username; }
        }
        public string Password
        {
            get { return password; }
        }

        public override string ToString()
        {
            return "username : " + username + "\n" +
                "password : " + password;
        }
    }
}
