using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet3 {
    class Program {
        static void Main(string[] args) {
            var catalog = new Catalog();
            CatalogBuilder.Build(catalog.Products);
            var customerType = new CustomerType(advanced:true);
            
            Customer customer = new CustomerBuilder()
                .SetAge(21)
                .SetName("John")
                .SetType(customerType)
                .SetDelieverInfo(home: 81, street: "Wall-street", appartmentNumber: 13, postalCode:213456);
            try { 
                customer.CustomerCart.AddProduct(catalog.Products[0]);
                customer.CustomerCart.AddProduct(catalog.Products[1], 2); 
                customer.CustomerCart.AddProduct(catalog.Products[0]);
                customer.CustomerCart.RemoveProduct(catalog.Products[0]);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                throw;
            }
            var order = new Order(customer, catalog);
            order.MakeOrder();
              
        }
    }
}
