using System;

namespace Demo
{
    static class ConsoleExtensions
    {
        public static void WriteLine(this string content) =>
            Console.WriteLine(content);
    }
}
