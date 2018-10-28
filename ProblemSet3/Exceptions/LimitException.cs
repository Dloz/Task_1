using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet3 {
    class LimitException : ApplicationException {
        private const string Format = "Cart has maximum of products";

        public LimitException() {
        }
        public override string Message => string.Format(Format);
    }
}
