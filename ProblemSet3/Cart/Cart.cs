using System.Collections.Generic;
using System.Linq;

namespace ProblemSet3 {
    public class Cart : ICarter {
        internal int Limit = 50;
        public readonly List<CartItem> Goods = new List<CartItem>();
        private int _amount = default(int);

        public int Amount {
            get => _amount;
            set => _amount = Goods.Count;
        }

        public void AddProduct(Product product, int amount = 1) {
            if (Goods.Count == Limit)
                throw new LimitException();
            if (Goods.Any(x => x.Product.ItemId == product.ItemId)) {
                Goods.Find(x => x.Product.ItemId == product.ItemId).Amount++;
                return;
            }
            Goods.Add((new CartItem(product)));
            Goods.Last().Amount = amount;
        }
        public void RemoveProduct(Product product, int amount = 1) {
            if (Goods.All(x => x.Product.ItemId != product.ItemId))
                throw new ContainsException();
            if (amount == Goods.Find(x => x.Product.ItemId == product.ItemId).Amount)
                Goods.RemoveAll(x => x.Product.ItemId == product.ItemId);
            else
                Goods.Find(x => x.Product.ItemId == product.ItemId).Amount -= amount;
                
        }
        public override string ToString() {
            var str = "";
            foreach (var product in Goods) {
                str += product.ToString() + "\n";
            }

            return str;
        }
    }
}