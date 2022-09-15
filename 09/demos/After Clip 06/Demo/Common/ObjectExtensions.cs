using System;

namespace Demo.Common
{
    public static class ObjectExtensions
    {
        public static TResult Map<T, TResult>(this T obj, Func<T, TResult> map) =>
            map(obj);
    }
}
