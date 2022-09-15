using System;
using Demo.Common;

namespace Demo.Finance
{
    public static class MoneyExtensions
    {
        public static Option<IMoney> PayableAt(this IMoney money, DateTime time)
        {
            switch (money)
            {
                case Cash _: 
                case GiftCard gift when time < gift.ValidBefore:
                case BankCard card when time < card.ValidBefore:
                    return new Some<IMoney>(money);
                default:
                    return None.Value;
            }
        }
    }
}
