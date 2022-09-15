using System;

namespace Demo
{
    static class ProductBuy
    {
        public static InvoiceLine Buy(this Product product, int quantity, 
            Func<Product, Amount, Amount> taxCalculator) =>
            product.GetPriceSpecification(quantity, taxCalculator)
                .ToInvoiceLine(product.Name);

        private static InvoiceLine 
            ToInvoiceLine(this (Amount basePrice, Amount tax) tuple, string label) =>
            new InvoiceLine(label, tuple.basePrice, tuple.tax);

        public static (Amount basePrice, Amount tax) 
            GetPriceSpecification(this Product product, int quantity,
                Func<Product, Amount, Amount> taxCalculator) =>
            product.GetBasePrice(quantity)
                .Map(basePrice => (basePrice, taxCalculator(product, basePrice)));

        private static TResult Map<T, TResult>(this T obj, Func<T, TResult> map) =>
            map(obj);

        private static Amount GetBasePrice(this Product product, int quantity) =>
            product.UnitPrice.Scale(quantity);

        public static Func<int, Amount> TotalPriceCalculator(
            this Product product, Func<Product, Amount, Amount> taxCalculator) =>
            quantity => product.GetPriceSpecification(quantity, taxCalculator)
                .Map(tuple => tuple.basePrice.Add(tuple.tax.Value));
    }
}
