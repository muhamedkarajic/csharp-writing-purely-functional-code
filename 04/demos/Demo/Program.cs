using System;

namespace Demo
{
    class Program
    {
        static void Work(Func<int, int> scale)
        {
            int y = scale(5);
            Console.WriteLine(y);
        }

        class ScaleClosure
        {
            public int environment;
            public int Scale(int arg) => this.environment * arg;
        }

        static void Main(string[] args)
        {
            var closure = new ScaleClosure() {environment = 2};

            closure.environment = 3;
            Work(closure.Scale);

            Console.ReadLine();
        }
    }
}
