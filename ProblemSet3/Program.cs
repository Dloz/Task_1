using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet3 {
    class Program {
        static void Main(string[] args) {
            Catalog catalog = new Catalog();
            CatalogBuilder.Build(catalog.Products);
            CustomerType customerType = new CustomerType(advanced:true);
            
            Customer customer = new CustomerBuilder()
                .SetAge(21)
                .SetName("John")
                .SetType(customerType)
                .SetDelieverInfo(home: 81, street: "Wall-street", appartmentNumber: 13, postalCode:213456);
            
            customer.CustomerCart = new Cart() {
                _limit = 50
            };
            customer.CustomerCart.AddProduct(catalog.Products[0]);
            customer.CustomerCart.AddProduct(catalog.Products[1]);
            
            
        }
    }
}
