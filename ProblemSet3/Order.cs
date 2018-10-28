using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {

    public class Order : IBuy {
        Customer _customer;
        List<Product> _products;
        Product _product;
        
        public Order(Customer customer, 
            Product product,
            List<Product> products = default(List<Product>)) {
            _customer = customer;
            _products = products;
            _product = product; // send order details into ctor and that's it

        }
        void IBuy.ReduceBalance(Customer customer) {
            customer.Balance -= _product.Price;
            customer.Spent += _product.Price;
        }
        string IBuy.Request() {
            return $"{_customer} has ordered {_products.ToString()}"; // override method ToString for LIst
        }
    }
}

