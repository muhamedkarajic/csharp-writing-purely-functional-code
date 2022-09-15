namespace Demo
{
    static class Arithmetic
    {
        public static Amount Scale(this Amount amount, decimal factor) =>
            new Amount(amount.Value * factor, amount.Currency);

        public static Amount Add(this Amount amount, decimal value) =>
            new Amount(amount.Value + value, amount.Currency);
    }
}
