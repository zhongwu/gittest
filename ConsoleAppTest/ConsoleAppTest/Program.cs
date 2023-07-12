using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // here is branch
            Console.WriteLine("Hello World!");
            var test = new Test { name = "test" };
            Console.WriteLine(test.name);
        }
    }
}
