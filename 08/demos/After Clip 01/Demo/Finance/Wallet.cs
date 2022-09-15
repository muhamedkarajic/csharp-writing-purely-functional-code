using System;
using System.Collections.Generic;
using System.Linq;
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

    public static class WalletExtensions
    {
        public static Wallet PayableAt(this Wallet wallet, DateTime at) =>
            new Wallet(wallet.Moneys
                .SelectOptional(money => money.PayableAt(at))
                .AsReiterable());
    }
}