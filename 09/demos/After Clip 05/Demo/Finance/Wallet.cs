using System.Collections.Immutable;

namespace Demo.Finance
{
    public class Wallet
    {
        public Currency BaseCurrency { get; }
        public ImmutableList<IMoney> Moneys { get; }

        public Wallet(Currency baseCurrency, ImmutableList<IMoney> moneys)
        {
            this.BaseCurrency = baseCurrency;
            this.Moneys = moneys;
        }
    }
}