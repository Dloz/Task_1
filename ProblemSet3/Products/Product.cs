using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class Product {
        public double Price { get; private set; }
        private string Name { get; set; }
        private string Manufacturer { get; set; }
        public int ItemId { get; private set; }

        public Product(double price = 0, string name = "", string manufacturer = "", int itemId = default(int)) {
            Price = price;
            Name = name;
            Manufacturer = manufacturer;
            ItemId = itemId;
        }

        public override string ToString() {
            return $"Price: {Price}, Name: {Name}, Manufacturer: {Manufacturer}, Id: {ItemId}";
        }
    }
}