using System;

namespace Demo.Finance
{
    public class Date
    {
        private DateTime Value { get; }

        public Date(int year, int month, int day)
        {
            this.Value = new DateTime(year, month, day);
        }

        public static implicit operator DateTime(Date date) => date.Value;
    }
}
