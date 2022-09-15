using System.Collections.Generic;
using Demo.Common;

namespace Demo.Finance
{
    public class Wallet
    {
        public Currency BaseCurrency { get; }
        public IEnumerable<IMoney> Moneys { get; }

        public Wallet(Currency baseCurrency, Reiterable<IMoney> moneys)
        {
            this.BaseCurrency = baseCurrency;
            this.Moneys = moneys;
        }
    }
}