using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Common
{
    public class Reiterable<T> : IEnumerable<T>
    {
        private IEnumerable<T> Data { get; }

        private Reiterable(IEnumerable<T> data)
        {
            this.Data = data;
        }

        public IEnumerator<T> GetEnumerator() =>
            this.Data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => 
            this.GetEnumerator();

        public static implicit operator Reiterable<T>(List<T> data) =>
            new Reiterable<T>(data);

        public static implicit operator Reiterable<T>(T[] data) =>
            new Reiterable<T>(data);

        public static Reiterable<T> From(IEnumerable<T> data)
        {
            switch (data)
            {
                case List<T> list: return list;
                case T[] array: return array;
                default: return new Reiterable<T>(data.ToList());
            }
        }
    }
}
