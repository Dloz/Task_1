using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public static class Validator {
        public static bool CheckAvailability(Product product, List<Product> collection) {
            return collection.Contains(product);
        }
    }
}