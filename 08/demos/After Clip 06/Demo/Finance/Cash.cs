namespace Demo.Finance
{
    public class Cash : IMoney
    {
        public Amount Value { get; }

        public Cash(Amount value)
        {
            this.Value = value;
        }
    }
}
