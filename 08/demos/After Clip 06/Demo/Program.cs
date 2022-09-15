using System;
using System.Collections.Generic;
using Demo.Common;
using Demo.Finance;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMoney> list = new List<IMoney>()
            {
                new Cash(new Amount(20, new Currency("USD"))),
                new GiftCard(new Amount(10, new Currency("EUR")), 
                             new Date(2021, 11, 4))
            };

            IEnumerable<IMoney> sequence = list;

            Reiterable<IMoney> moneys = sequence.AsReiterable();

            Console.ReadLine();
        }
    }
}
