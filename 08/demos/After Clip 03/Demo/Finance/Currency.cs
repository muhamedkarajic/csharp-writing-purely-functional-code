using System;

namespace Demo.Finance
{
    public class Currency : IEquatable<Currency>
    {
        public string Symbol { get; }

        public Currency(string symbol)
        {
            this.Symbol = !string.IsNullOrWhiteSpace(symbol)
                ? symbol
                : throw new ArgumentException(nameof(symbol));
        }

        public bool Equals(Currency other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(Symbol, other.Symbol);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Currency) obj);
        }

        public override int GetHashCode() => 
            (Symbol != null ? Symbol.GetHashCode() : 0);

        public static bool operator ==(Currency a, Currency b) =>
            (object.ReferenceEquals(a, null) && object.ReferenceEquals(b, null)) ||
            (!object.ReferenceEquals(a, null) && a.Equals(b));

        public static bool operator !=(Currency a, Currency b) =>
            !(a == b);

        public override string ToString() => this.Symbol;
    }
}
