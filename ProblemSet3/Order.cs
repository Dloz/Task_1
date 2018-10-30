using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {

    public class Order {
        Customer _customer;
        public Order(Customer customer) {
            _customer = customer;
        }

        public void MakeOrder() {
            _customer.ReduceBalance();
            _customer.Request();
            _customer.CustomerCart = null;
        }
        
    }
}

