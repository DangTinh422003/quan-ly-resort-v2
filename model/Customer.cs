using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class Customer
    {
        private string id;
        private string fullname;
        private DateTime dateOfBirth;
        private string phoneNumber;
        private string email;
        private string address;

        public Customer() { }
        public Customer(string id, string fullname, DateTime dateOfBirth, string phoneNumber, string email, string address)
        {
            this.Id = id;
            this.DateOfBirth = dateOfBirth;
            this.Fullname = fullname;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Address = address;
        }

        public string Id { get => id; set => id = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            return "Customer: " + this.Id + " " + this.Fullname + " " + this.DateOfBirth.ToString("yyyy-MM-dd") + " " + this.PhoneNumber + " " + this.Email + " " + this.Address;
        }
    }
}
