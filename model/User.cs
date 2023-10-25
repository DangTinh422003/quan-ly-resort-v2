using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class User
    {
        protected string id;
        protected string fullname;
        protected string phoneNumber;
        protected string email;
        protected string address;
        protected Account account;
        protected string role;


        public User()
        {
        }

        public User(string id, string fullname, string phoneNumber, string email, string address, Account account, string role)
        {
            this.id = id;
            this.fullname = fullname;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.account = account;
            this.role = role;
        }

        public User(User user)
        {
            this.id = user.id;
            this.fullname = user.fullname;
            this.phoneNumber = user.phoneNumber;
            this.email = user.email;
            this.address = user.address;
            this.account = user.account;
            this.role = user.role;
        }
    }
}
