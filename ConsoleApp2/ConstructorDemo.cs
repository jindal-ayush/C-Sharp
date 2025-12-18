using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class ConstructorDemo
    {
        static ConstructorDemo()
        {
            Console.WriteLine("static construcor is called");
        }
        public ConstructorDemo()
        {
            Console.WriteLine("static nom construcor is called");
        }
        public static void Main(string[] args)
        {

        }
    }
}
