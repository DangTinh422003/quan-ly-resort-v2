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
        private string email;
        private string role = "employee"; // "admin

        public Account(string username, string password, string email, string role)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Role = role;
        }

        public Account(Account account)
        {
            this.Username = account.Username;
            this.Password = account.Password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Create_at { get => create_at; set => create_at = value; }
        public string Email { get => email; set => email = value; }
        public string Role { get => role; set => role = value; }

        public override string ToString()
        {
            return "username : " + Username + "\n" +
                "password : " + Password;
        }
    }
}
