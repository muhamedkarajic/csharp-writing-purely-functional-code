using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void PrintPrices(Product product, int from, int to) =>
            Enumerable.Range(from, to - from + 1)
                .Select(quantity => (quantity, totalPrice: product.Buy(quantity).TotalPrice))
                .Select(tuple => $"{tuple.quantity}\t{tuple.totalPrice}")
                .Join(Environment.NewLine)
                .WriteLine();

        static void Main(string[] args)
        {
            PrintPrices(
                new Product("Steering wheel",
                    new Amount(20, new Currency("USD"))),
                1, 10);

            Console.ReadLine();
        }
    }
}
