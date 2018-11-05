using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSet3 {
    public class Customer: IBuyable {
        public double _discount = default(double);

        public int Age { get; set; }
        public double Balance { get; set; }
        public double Spent { get; set; }
        public Cart CustomerCart { get; set; } = new Cart();
        public CustomerType Type { get; set; } = new CustomerType();

        public Name Name { get; set; }
        public DelieverInfo DelieverInfo { get; set; }
        
        private void ReduceBalance() {
            foreach (var item in CustomerCart._goods) {
                Balance -= item.Product.Price;
                Spent += item.Product.Price;
            }
        }
        private void Request() {
            Console.WriteLine($"{Name.ToString()} has ordered {CustomerCart.ToString()}");
        }

        public void Buy() {
            ReduceBalance();
            Request();
        }

    }


    public class CustomerBuilder {
        private Customer customer;
        public CustomerBuilder() {
            customer = new Customer();
        }
        public CustomerBuilder SetName(string firstName = "", string lastName = "") {
            Name name = new Name(firstName: firstName, lastName: lastName);
            customer.Name = name;
            return this;
        }
        public CustomerBuilder SetType(CustomerType type) {
            customer.Type = type;
            return this;
        }
        public CustomerBuilder SetAge(int age) {
            customer.Age = age > 0 ? age : 0;
            return this;
        }
        public CustomerBuilder SetDelieverInfo(int home,
                            string street,
                            int postalCode,
                            int appartmentNumber = 0) {
            customer.DelieverInfo = new DelieverInfo(home, street, postalCode, appartmentNumber);
            return this;
        }

        public static implicit operator Customer(CustomerBuilder builder) {
            return builder.customer;
        }
    }
}