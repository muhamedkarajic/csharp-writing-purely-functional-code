using System.Collections.Generic;
using Demo.Common;

namespace Demo.Finance
{
    public class Wallet
    {
        public IEnumerable<IMoney> Moneys { get; }

        public Wallet(Reiterable<IMoney> moneys)
        {
            this.Moneys = moneys;
        }
    }
}