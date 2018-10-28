using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public interface IBuy {
        void ReduceBalance(Customer customer);
        string Request();
    }
}