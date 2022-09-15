using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    static class StringExtensions
    {
        public static string Join(this IEnumerable<string> sequence, string separator) =>
            string.Join(separator, sequence.ToArray());
    }
}
