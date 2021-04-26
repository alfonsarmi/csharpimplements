using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IClass
    {
        public void TestMethod();

        public void TestMethod2()
        {
            System.Console.WriteLine("Hello");
        }
    }
}
