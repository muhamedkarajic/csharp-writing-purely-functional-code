using System;

namespace Demo.Finance
{
    public class BankCard : IMoney
    {
        public DateTime ValidBefore { get; }

        public BankCard(Month validThru)
        {
            this.ValidBefore = ((DateTime)validThru).AddMonths(1);
        }
    }
}
