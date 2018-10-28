using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class Customer {
        private Guid _id = new Guid();
        public double _discount = default(double);

        public int Age { get; set; }
        public double Balance { get; set; }
        public double Spent { get; set; }
        public Cart Cart { get; set; }
        public CustomerType Type { get; set; }
        public Name Name { get; set; }
        public DelieverInfo DelieverInfo { get; set; }

        
    }


    public class UserBuilder {
        private Customer customer;
        public UserBuilder() {
            customer = new Customer();
        }
        public UserBuilder SetName(string firstName = "", string lastName = "") {
            Name name = new Name(firstName: firstName, lastName: lastName);
            customer.Name = name;
            return this;
        }
        public UserBuilder SetType(CustomerType type) {
            customer.Type = type;
            return this;
        }
        public UserBuilder SetAge(int age) {
            customer.Age = age > 0 ? age : 0;
            return this;
        }
        public UserBuilder SetDelieverInfo(int home,
                            string street,
                            int postalCode,
                            int appartmentNumber = 0) {
            customer.DelieverInfo = new DelieverInfo(home, street, postalCode, appartmentNumber);
            return this;
        }

        public static implicit operator Customer(UserBuilder builder) {
            return builder.customer;
        }
    }
}