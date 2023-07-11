using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // add branch_1
            // here is the branch change.
            Console.WriteLine("Hello World!");
            var test = new Test { firstname = "first", lastname ="last" };
            Console.WriteLine(test.fullname);
        }
    }
}
