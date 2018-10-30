using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class Cart : ICarter {
        public List<CartItem> _goods;
        internal int _limit;
        private int _amount;

        public int Amount {
            get => _amount;
            set => _amount = _goods.Count;
        }
        public Catalog Catalog { get; set; }

        public void AddProduct(Product product, int amount = 1) {
            if (!Validator.CheckAvailability(product, Catalog.Products)) 
                throw  new ContainsException();
              
            if (_goods.Count == _limit)
                throw new LimitException();
            for (int i = 0; i < amount; i++) {
                _goods.Add(product as CartItem);
            }
        }
        public void RemoveProduct(Product product, int amount = 1) {
            if (!_goods.Contains(product))
                throw new ContainsException();
            for (int i = 0; i < amount; i++) {
                _goods.Remove(product as CartItem);
            }
        }

        public override string ToString() {
            return _goods.ToString();
        }
    }
}