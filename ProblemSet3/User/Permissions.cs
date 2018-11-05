namespace ProblemSet3 {
    public static class Permissions {
        //private const int Bonus = 100;
        private const double discountAmount = 0.1;

        public static void GiveBonus(Customer customer, double Bonus = 0) {
            customer.Balance += Bonus;
        }

        public static void GiveUnlimitCart(Customer customer) 
            => customer.CustomerCart.Limit = int.MaxValue; // without static

        public static void GiveDiscount(Customer customer) {
            customer._discount += discountAmount;
        }
    }
}