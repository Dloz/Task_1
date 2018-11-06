using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProblemSet3 {
    public class Catalog {
        public readonly List<Product> Products =  new List<Product>();

        public override string ToString() {
            var str = "";
            foreach (var product in Products) {
                str += product.ToString() + "\n";
            }

            return str;
        }
    }

    public static class CatalogBuilder {

        public static void Build(List<Product> products) {
            products.Add(new Product(123d,"Shirt", "abc", 1));
            products.Add(new Product(100d,"T-shirt", "abc", 2));
            products.Add(new Product(200d,"Pants", "abc", 3));
            products.Add(new Clothes(250d,"Shirts","Manufacturer", 4, "M", "Black"));
            products.Add(new Shoes());
        }
    }
}
