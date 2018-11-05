using System.Collections.Generic;
using System.Linq;

namespace ProblemSet3 {
    public class Cart : ICarter {
        internal int Limit = 50;
        public List<CartItem> _goods = new List<CartItem>();
        private int _amount = default(int);

        public int Amount {
            get => _amount;
            set => _amount = _goods.Count;
        }

        public void AddProduct(Product product, int amount = 1) {
            if (_goods.Count == Limit)
                throw new LimitException();
            if (_goods.Any(x => x.Product.ItemId == product.ItemId)) {
                _goods.Find(x => x.Product.ItemId == product.ItemId).Amount++;
                return;
            }
            _goods.Add((new CartItem(product)));
            _goods.Last().Amount = amount;
        }
        public void RemoveProduct(Product product, int amount = 1) {
            if (_goods.All(x => x.Product.ItemId != product.ItemId))
                throw new ContainsException();
            if (amount == _goods.Find(x => x.Product.ItemId == product.ItemId).Amount)
                _goods.RemoveAll(x => x.Product.ItemId == product.ItemId);
            else
                _goods.Find(x => x.Product.ItemId == product.ItemId).Amount -= amount;
                
        }
        public override string ToString() {
            // TODO 
        }
    }
}