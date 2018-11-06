using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {

    public class Order {
        private readonly Customer _customer;
        private Catalog _catalog;
        public Order(Customer customer, Catalog catalog) {
            _customer = customer;
            _catalog = catalog;
        }

        public void MakeOrder() {
            _customer.Buy();
            _customer.CustomerCart = null;
        }
        
    }
}

