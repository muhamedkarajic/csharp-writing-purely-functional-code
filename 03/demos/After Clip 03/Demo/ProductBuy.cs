using System;

namespace Demo
{
    static class ProductBuy
    {
        public static InvoiceLine Buy(this Product product, int quantity) =>
            new InvoiceLine(
                product.Name,
                product.UnitPrice.Scale(quantity),
                product.UnitPrice.Scale(quantity).Scale(.20M));

        public static Func<int, Amount> TotalPriceCalculator(this Product product) => 
            quantity => product.Buy(quantity).TotalPrice;
    }
}
