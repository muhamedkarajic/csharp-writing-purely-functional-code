using System;

namespace Demo.Finance
{
    public class GiftCard : IMoney
    {
        public Amount Value { get; }
        public Date ValidThru { get; }

        public DateTime ValidBefore => 
            ((DateTime)this.ValidThru).AddDays(1);

        public GiftCard(Amount value, Date validThru)
        {
            this.Value = value;
            this.ValidThru = validThru;
        }
    }
}
