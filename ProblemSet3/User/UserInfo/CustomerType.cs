using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class CustomerType {
        public bool Regular { get; set; }
        public bool Advanced { get; set; } 
        public bool VIP { get; set; }

        public CustomerType(bool advanced = false, bool VIP = false) {
            Regular = true;
            Advanced = advanced;
            this.VIP = VIP;
        }
    }
}