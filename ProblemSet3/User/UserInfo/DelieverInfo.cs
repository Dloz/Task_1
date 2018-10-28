using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class DelieverInfo {
        private int _home;
        private string _street;
        private int _postalCode;
        private int _appartmentNumber;

        public DelieverInfo(int home, 
                            string street, 
                            int postalCode, 
                            int appartmentNumber)
        {
            _home = home;
            _street = street;
            _postalCode = postalCode;
            _appartmentNumber = appartmentNumber;
        }
    }
}