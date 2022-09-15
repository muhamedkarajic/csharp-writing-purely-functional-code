using System;

namespace Demo.Finance
{
    public class BankCard : IMoney
    {
        public Month ValidThru { get; }

        public DateTime ValidBefore =>
            ((DateTime) this.ValidThru).AddMonths(1);

        public BankCard(Month validThru)
        {
            this.ValidThru = validThru;
        }
    }
}
