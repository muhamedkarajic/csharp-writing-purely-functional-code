using System;
using System.Collections.Generic;

namespace Demo
{
    class Element<T>
    {
        public T Content { get; set; }
        public Element<T> Next { get; set; }
    }

    static class Hashing
    {
        private static int GetHashEntry<T>(this Element<T>[] set, T value)
        {
            if (object.ReferenceEquals(value, null))
                return 0;

            int code = value.GetHashCode();
            int entry = code % set.Length;
            if (entry < 0) entry += set.Length;
            return entry;
        }

        public static void Add<T>(this Element<T>[] set, T value)
        {
            int entry = set.GetHashEntry(value);
            Console.WriteLine($"Adding {value} to set[{entry}]");

            Element<T> element = new Element<T>()
            {
                Content = value,
                Next = set[entry]
            };

            set[entry] = element;
        }

        public static bool Contains<T>(this Element<T>[] set, T value)
        {
            int entry = set.GetHashEntry(value);
            Console.WriteLine($"Searching for {value} in set[{entry}]");

            for (Element<T> cur = set[entry]; cur != null; cur = cur.Next)
            {
                if (cur.Content.Equals(value))
                {
                    return true;
                }
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Currency eur = Currency.EUR;
            Element<Currency>[] set = new Element<Currency>[7];

            set.Add(eur);
            if (set.Contains(eur))
            {
                Console.WriteLine("Suspect found!");
            }
            else
            {
                Console.WriteLine("Suspect NOT found!");
            }

            Console.ReadLine();
        }
    }
}
