using System;

namespace Demo
{
    class Amount
    {
        public decimal Value { get; }
        public Currency Currency { get; }

        public Amount(decimal value, Currency currency)
        {
            this.Value = value;
            this.Currency = currency 
                ?? throw new ArgumentNullException(nameof(currency));
        }

        public override string ToString() => $"{this.Value} {this.Currency}";
    }
}