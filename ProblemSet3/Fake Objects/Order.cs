using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {

    public class Order {
        private Customer _customer;
        private Catalog _catalog;
        public Order(Customer customer, Catalog catalog) {
            _customer = customer;
            _catalog = catalog;
        }

        public void MakeOrder() {
            _customer.ReduceBalance();
            _customer.Request();
            foreach (var product in _customer.CustomerCart._goods) {
                if (Validator.CheckAvailability(product, _catalog.Products))
                    _customer.CustomerCart._goods.Remove(product); // TODO remove all products
            }
            _customer.CustomerCart = null;
        }
        
    }
}

