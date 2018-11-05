using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProblemSet3 {
    public class Catalog {
        public List<Product> Products =  new List<Product>();

        public override string ToString() {
            return Products.ToString();
        }
    }

    public static class CatalogBuilder {

        public static void Build(List<Product> products) {
            products.Add(new Product(123d,"Shirt", "abc", 1));
            products.Add(new Product(100d,"T-shirt", "abc", 2));
            products.Add(new Product(200d,"Pants", "abc", 3));
        }

        static void Read(string path) {
            using (var sr = new StreamReader(path)) {
                // read data from text file
            
            }
        }
    }
}
