using System;

namespace Demo
{
    class Currency
    {
        public string Symbol { get; }

        public Currency(string symbol)
        {
            this.Symbol = !string.IsNullOrWhiteSpace(symbol)
                ? symbol
                : throw new ArgumentException(nameof(symbol));
        }

        public override string ToString() => this.Symbol;
    }
}
