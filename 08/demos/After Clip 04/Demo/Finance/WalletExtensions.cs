using System;
using System.Linq;
using Demo.Common;

namespace Demo.Finance
{
    public static class WalletExtensions
    {
        public static Wallet PayableAt(this Wallet wallet, DateTime at) =>
            new Wallet(
                wallet.BaseCurrency,
                wallet.Moneys.PayableAt(at).AsReiterable());

        public static Wallet With(this Wallet wallet, Currency baseCurrency) =>
            new Wallet(baseCurrency, wallet.Moneys.AsReiterable());

        public static Wallet Add(this Wallet wallet, IMoney money) =>
            new Wallet(
                wallet.BaseCurrency,
                wallet.Moneys.Concat(new[] {money}).ToList());
    }
}