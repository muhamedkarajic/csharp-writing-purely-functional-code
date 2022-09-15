using System;
using System.Collections.Immutable;

namespace Demo.Finance
{
    public static class WalletExtensions
    {
        public static Wallet PayableAt(this Wallet wallet, DateTime at) =>
            new Wallet(
                wallet.BaseCurrency,
                wallet.Moneys.PayableAt(at).ToImmutableList());

        public static Wallet With(this Wallet wallet, Currency baseCurrency) =>
            new Wallet(baseCurrency, wallet.Moneys);

        public static Wallet Add(this Wallet wallet, IMoney money) =>
            new Wallet(
                wallet.BaseCurrency,
                wallet.Moneys.Add(money));


        public static void Demo(Wallet wallet)
        {
            Wallet final = wallet
                .PayableAt(DateTime.UtcNow)
                .With(new Currency("USD"))
                .Add(new Cash(new Amount(5, new Currency("EUR"))));
        }
    }
}