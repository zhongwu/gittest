﻿using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // here is the branch change.
            Console.WriteLine("Hello World!");
            var test = new Test { name = "test" };
            Console.WriteLine(test.name);
        }
    }
}
