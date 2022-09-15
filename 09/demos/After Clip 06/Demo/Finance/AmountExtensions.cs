namespace Demo.Finance
{
    public static class AmountExtensions
    {
        public static Amount Scale(this Amount amount, decimal factor) =>
            new Amount(amount.Value * factor, amount.Currency);

        public static Amount Add(this Amount amount, decimal value) =>
            new Amount(amount.Value + value, amount.Currency);

        public static (Amount subtracted, Amount remaining) Subtract(
            this Amount from, Amount amount) =>
            from.Currency == amount.Currency
                ? from.SafeTake(amount.Value)
                : (amount.Currency.Zero(), from);

        private static (Amount subtracted, Amount remaining) SafeTake(
            this Amount from, decimal value) =>
            (new Amount(value, from.Currency), 
             new Amount(from.Value - value, from.Currency));
    }
}
