using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace quan_ly_resort_v2.model
{
    public class Account
    {
        private string username;
        private string password;
        private DateTime create_at;
        private int role { get; set; }

        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public Account(Account account)
        {
            this.Username = account.Username;
            this.Password = account.Password;
        }

        public Account(string username, string password, int role, DateTime create_at)
        {
            this.Username = username;
            this.Password = password;
            this.role = role;
            this.create_at = create_at;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Create_at { get => create_at; set => create_at = value; }

        public override string ToString()
        {
            return "username : " + Username + "\n" +
                "password : " + Password;
        }
    }
}
