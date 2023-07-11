using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // this main branch of gittest.
            Console.WriteLine("Hello World!");
            var test = new Test { firstname = "test" };
            Console.WriteLine(test.fullname);
        }
    }
}
