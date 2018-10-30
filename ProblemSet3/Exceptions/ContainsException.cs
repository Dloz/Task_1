using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet3 {
    public class ContainsException: ApplicationException {
        private const string Format = "Cart does not contain this product";

        public ContainsException() {

        }
        public override string Message => string.Format(Format);

        // 
    }
}
