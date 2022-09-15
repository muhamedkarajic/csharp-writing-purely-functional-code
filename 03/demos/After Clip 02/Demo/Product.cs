using System;

namespace Demo
{
    class Product
    {
        public string Name { get; }
        public Amount UnitPrice { get; }

        public Product(string name, Amount unitPrice)
        {
            this.Name = !string.IsNullOrWhiteSpace(name)
                ? name : throw new ArgumentException(nameof(name));
            this.UnitPrice = unitPrice 
                ?? throw new ArgumentNullException(nameof(unitPrice));
        }
    }
}
