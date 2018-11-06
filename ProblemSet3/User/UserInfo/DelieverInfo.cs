using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class DelieverInfo {
        private readonly int _home;
        private readonly string _street;
        private readonly int _postalCode;
        private readonly int _appartmentNumber;

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

        public override string ToString() {
            return
                $"Home: {_home}, Street: {_street}, Postal Code: {_postalCode}, Apartment Number: {_appartmentNumber}";
        }
    }
}