using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class CustomerType {
        public bool Advanced { get; private set; }
        public bool Vip { get; private set; }

        public CustomerType(bool advanced = false, bool vip = false) {
            Advanced = advanced;
            this.Vip = vip;
        }

        public override string ToString() {
            return $"Customer " + (Advanced ? "is " : "is not ") + "advanced "
                   + "and customer " + (Vip ? "is " : "is not ") + "VIP \n";
        }
    }
}