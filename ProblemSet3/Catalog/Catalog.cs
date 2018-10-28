using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProblemSet3 {
    public class Catalog {
        public List<Product> Products {
            get => default(List<Product>);
            set {
                
            }
        }
    }

    public static class CatalogBuilder {

        static void Build(List<Product> products) {
            products.Add(new Product(123d,"Shirt", "abc"));
            products.Add(new Product(100d,"T-shirt", "abc"));
            products.Add(new Product(200d,"Pants", "abc"));
        }

        static void Read(string path) {
            using (var sr = new StreamReader(path)) {
                // read data from text file
            
            }
        }
    }
}
