using System;

namespace Demo.Finance
{
    public class BankCard : IMoney
    {
        public DateTime ValidBefore { get; }

        public BankCard(Month validBefore)
        {
            this.ValidBefore = validBefore;
        }
    }
}
