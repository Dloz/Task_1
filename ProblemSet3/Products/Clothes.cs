using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class Clothes : Product {
        private string Size { get; set; }
        private string Color { get; set; }

        public Clothes(double price = 0, string name = "", string manufacturer = "", 
            int itemId = default(int), string size = "unknown", string color = "unknown")
            :base(price,name,manufacturer,itemId) {
            Size = size;
        }

        public override string ToString() {
            return base.ToString() + $"Size: {Size}, Color: {Color}";
        }
    }
}