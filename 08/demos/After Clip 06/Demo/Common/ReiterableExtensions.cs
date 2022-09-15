using System.Collections.Generic;

namespace Demo.Common
{
    public static class ReiterableExtensions
    {
        public static Reiterable<T> AsReiterable<T>(this IEnumerable<T> data) =>
            Reiterable<T>.From(data);
    }
}