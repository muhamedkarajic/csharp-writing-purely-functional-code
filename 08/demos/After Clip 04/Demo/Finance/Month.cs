using System;

namespace Demo.Finance
{
    public class Month
    {
        private DateTime Value { get; }

        public Month(int year, int month)
        {
            this.Value = new DateTime(year, month, 1);
        }

        public static implicit operator DateTime(Month month) => month.Value;
    }
}
