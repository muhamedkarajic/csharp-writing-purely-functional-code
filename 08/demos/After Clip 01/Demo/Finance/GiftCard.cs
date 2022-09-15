using System;

namespace Demo.Finance
{
    public class GiftCard : IMoney
    {
        public Amount Value { get; }
        public DateTime ValidBefore { get; }

        public GiftCard(Amount value, Date validBefore)
        {
            this.Value = value;
            this.ValidBefore = validBefore;
        }
    }
}
