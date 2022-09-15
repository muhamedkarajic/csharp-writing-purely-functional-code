using System;

namespace Demo
{
    class Amount : IEquatable<Amount>
    {
        public decimal Value { get; }
        public Currency Currency { get; }

        public Amount(decimal value, Currency currency)
        {
            this.Value = value;
            this.Currency = currency 
                ?? throw new ArgumentNullException(nameof(currency));
        }

        public bool Equals(Amount other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Value == other.Value && Equals(Currency, other.Currency);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Amount) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Value.GetHashCode() * 397) ^ (Currency != null ? Currency.GetHashCode() : 0);
            }
        }

        public static bool operator ==(Amount a, Amount b) =>
            (object.ReferenceEquals(a, null) && object.ReferenceEquals(b, null)) ||
            (!object.ReferenceEquals(a, null) && a.Equals(b));

        public static bool operator !=(Amount a, Amount b) =>
            !(a == b);

        public override string ToString() => $"{this.Value} {this.Currency}";
    }
}