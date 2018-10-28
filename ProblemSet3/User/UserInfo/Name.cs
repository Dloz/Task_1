using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public struct Name {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Name(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString() {
            return $"{FirstName} {LastName}";
        }
    }
}