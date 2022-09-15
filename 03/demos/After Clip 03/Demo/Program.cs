using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void PrintPrices(int from, int to, Func<int, Amount> priceOf) =>
            Enumerable.Range(from, to - from + 1)
                .Select(quantity => (quantity, price: priceOf(quantity)))
                .Select(tuple => $"{tuple.quantity}\t{tuple.price}")
                .Join(Environment.NewLine)
                .WriteLine();

        static void Main(string[] args)
        {
            Product product =
                new Product("Steering wheel",
                    new Amount(20, new Currency("USD")));

            Func<int, Amount> priceCalculator = 
                quantity => product.Buy(quantity).TotalPrice;

            PrintPrices(10, 19, priceCalculator);

            Console.ReadLine();
        }
    }
}
