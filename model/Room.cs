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
        private string type;
        private string bedStyle;
        private string state;
        private double price;
        private bool isClean;
        private bool isFixed;

        public Room(string id, string type, string bedStyle, string state, double price, bool isClean, bool isFixed)
        {
            this.Id = id;
            this.Type = type;
            this.BedStyle = bedStyle;
            this.State = state;
            this.Price = price;
            this.IsClean = isClean;
            this.IsFixed = isFixed;
        }

        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string BedStyle { get => bedStyle; set => bedStyle = value; }
        public string State { get => state; set => state = value; }
        public double Price { get => price; set => price = value; }
        public bool IsClean { get => isClean; set => isClean = value; }
        public bool IsFixed { get => isFixed; set => isFixed = value; }

        public override string ToString()
        {
            return "Room: " + this.Id + " - " + this.Type + " - " + this.BedStyle + " - " + this.State + " - " + this.Price + " - " + this.IsClean + " - " + this.IsFixed;
        }
    }
}
