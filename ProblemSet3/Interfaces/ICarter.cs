using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public interface ICarter {
        void AddProduct(Product product);
        void RemoveProduct(Product product);

    }
}