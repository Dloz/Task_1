using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class Shoes : Product {
        private string Size { get; set; }
        private string Color { get; set; }
        private string Type { get; set; }

        public Shoes(double price = 0, string name = "", string manufacturer = "", 
            int itemId = default(int), string size = "unknown", string color = "unknown", string type = "unknown")
            :base(price,name,manufacturer,itemId) {
            Size = size;
            Color = color;
            Type = type;
        }

        public override string ToString() {
            return base.ToString() + $"Size: {Size}, Color: {Color}, Type: {Type}";
        }
    }
}