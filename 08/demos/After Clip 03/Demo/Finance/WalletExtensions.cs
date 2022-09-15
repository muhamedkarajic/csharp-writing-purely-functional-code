using System;
using Demo.Common;

namespace Demo.Finance
{
    public static class WalletExtensions
    {
        public static Wallet PayableAt(this Wallet wallet, DateTime at) =>
            new Wallet(wallet.Moneys.PayableAt(at).AsReiterable());
    }
}