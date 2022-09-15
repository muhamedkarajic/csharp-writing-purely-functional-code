namespace Demo.Common
{
    public class Some<T> : Option<T>
    {
        public T Content { get; }

        public Some(T content)
        {
            this.Content = content;
        }

        public static implicit operator T(Some<T> value) =>
            value.Content;
    }
}