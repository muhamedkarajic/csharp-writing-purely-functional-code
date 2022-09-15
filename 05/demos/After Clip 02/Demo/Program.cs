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
        private static int GetHashEntry(this Element<int>[] set, int value)
        {
            int entry = value % set.Length;
            if (entry < 0) entry += set.Length;
            return entry;
        }

        public static void Add(this Element<int>[] set, int value)
        {
            int entry = set.GetHashEntry(value);
            Console.WriteLine($"Adding {value} to set[{entry}]");

            Element<int> element = new Element<int>()
            {
                Content = value,
                Next = set[entry]
            };

            set[entry] = element;
        }

        public static bool Contains(this Element<int>[] set, int value)
        {
            int entry = set.GetHashEntry(value);
            Console.WriteLine($"Searching for {value} in set[{entry}]");

            for (Element<int> cur = set[entry]; cur != null; cur = cur.Next)
            {
                if (cur.Content == value)
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
            Element<int>[] set = new Element<int>[7];

            set.Add(22);
            set.Add(33);
            set.Add(54);

            if (set.Contains(33))
            {
                Console.WriteLine("Suspect found!");
            }

            Console.ReadLine();
        }
    }
}
