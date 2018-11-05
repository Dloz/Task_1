using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public interface ICarter {
        void AddProduct(Product product, int amount);
        void RemoveProduct(Product product, int amount);
    }
}