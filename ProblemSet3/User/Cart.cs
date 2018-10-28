using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class Cart : ICarter {
        private List<Product> _goods;
        internal int _limit;

        private int _amount;

        public int Amount {
            get => _amount;
            set => _amount = _goods.Count;
        }

        void ICarter.AddProduct(Product product) {
            if (_goods.Count == _limit)
                throw new LimitException();
            else
                _goods.Add(product);

        }
         void ICarter.RemoveProduct(Product product) {
            if (_goods.Contains(product))
                _goods.Remove(product);
            else
                throw new ContainsException();
        }
    }
}