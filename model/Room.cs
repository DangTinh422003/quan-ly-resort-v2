using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_resort_v2.model
{
    public class Room
    {
        private string id;
        private string name;
        private string type;
        private double price;
        private string desc;
        private string stateBooking;
        private int rating;
        private int personInRoom;
        private bool accessChildren;

        public Room() { }

        public Room(string id, string name, string type, double price, string desc, string stateBooking, int rating, int personInRoom, bool accessChildren)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.Price = price;
            this.Desc = desc;
            this.StateBooking = stateBooking;
            this.Rating = rating;
            this.PersonInRoom = personInRoom;
            this.AccessChildren = accessChildren;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
        public string Desc { get => desc; set => desc = value; }
        public string StateBooking { get => stateBooking; set => stateBooking = value; }
        public int Rating { get => rating; set => rating = value; }
        public int PersonInRoom { get => personInRoom; set => personInRoom = value; }
        public bool AccessChildren { get => accessChildren; set => accessChildren = value; }
    }
}
