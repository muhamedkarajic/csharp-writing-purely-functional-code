﻿namespace Demo.Finance
{
    public static class CurrencyExtensiosn
    {
        public static Amount Zero(this Currency currency) =>
            new Amount(0, currency);
    }
}