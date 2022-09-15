using System;

namespace Demo
{
    sealed class Currency : IEquatable<Currency>
    {
        private string Symbol { get; }

        private Currency(string symbol)
        {
            this.Symbol = symbol;
        }

        public static Currency USD => new Currency("USD");
        public static Currency EUR => new Currency("EUR");
        public static Currency JPY => new Currency("JPY");

        public override int GetHashCode() =>
            this.Symbol.GetHashCode();

        public override bool Equals(object obj) =>
            obj != null && obj is Currency cur && this.Equals(cur);

        public bool Equals(Currency obj) =>
            !object.ReferenceEquals(obj, null) && obj.Symbol == this.Symbol;

        public static bool operator ==(Currency a, Currency b) =>
            object.ReferenceEquals(a, b) ||
            (!object.ReferenceEquals(a, null) && a.Equals(b));

        public static bool operator !=(Currency a, Currency b) => !(a == b);

        public override string ToString() => 
            this.Symbol;
    }
}
