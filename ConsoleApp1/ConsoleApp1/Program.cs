using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IClass test = new Class1();
            test.TestMethod();
            test.TestMethod2();
        }
    }
}
