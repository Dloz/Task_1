using System;

namespace ProblemSet3 {
    public class CartItem {
        public int Amount { get; set; }
        public readonly Product Product;

        public CartItem(Product product) {
            Product = product;
        }

        public override string ToString() {
            return Product.ToString() + $"Amount: {Amount}";
        }
    }
}