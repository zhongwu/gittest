using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is branch 1
            Console.WriteLine("Hello World!");
            var test = new Test { firstname = "first", lastname ="last" };
            Console.WriteLine(test.fullname);
        }
    }
}
