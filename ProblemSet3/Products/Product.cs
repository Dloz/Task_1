﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class Product {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int ItemId { get; set; }

        public Product(double price = 0, string name = "", string manufacturer = "", int itemId = default(int)) {
            Price = price;
            Name = name;
            Manufacturer = manufacturer;
            ItemId = itemId;
        }
    }
}