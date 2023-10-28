using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        protected string username;

        protected string Id { get => id; set => id = value; }
        protected string Fullname { get => fullname; set => fullname = value; }
        protected string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        protected string Email { get => email; set => email = value; }
        protected string Address { get => address; set => address = value; }

        public User()
        {
        }

        public User(string id, string fullname, string phoneNumber, string email, string address, string username)
        {
            this.Id = id;
            this.Fullname = fullname;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.username = username;
        }

        public User(User user)
        {
            this.Id = user.Id;
            this.Fullname = user.Fullname;
            this.PhoneNumber = user.PhoneNumber;
            this.Email = user.Email;
            this.Address = user.Address;
            this.username = user.username;

        }
    }
}
