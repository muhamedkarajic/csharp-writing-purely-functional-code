using System;

namespace Demo
{
    sealed class Currency
    {
        private string Symbol { get; }

        private Currency(string symbol)
        {
            this.Symbol = symbol;
        }

        public static Currency USD => new Currency("USD");
        public static Currency EUR => new Currency("EUR");
        public static Currency JPY => new Currency("JPY");

        private static Random Rng { get; } = new Random(709);

        public override int GetHashCode() =>
            Rng.Next();

        public override string ToString() => 
            this.Symbol;
    }
}
