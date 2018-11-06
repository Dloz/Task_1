using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class Accesories : Product {
        private string Type { get; set; }
        
        public Accesories(double price = 0, string name = "", string manufacturer = "", 
            int itemId = default(int), string size = "unknown", string type = "unknown")
            :base(price,name,manufacturer,itemId) {
            Type = type;
        }

        public override string ToString() {
            return base.ToString() + $"Type: {Type}";
        }
    }
}