using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Specifiers
    { 
        private void Test1()
        {
            Console.WriteLine("private method");
        }
        internal void Test2()
        {
            Console.WriteLine("internal method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("protected internal method");
        }
        protected void Test3()
        {
            Console.WriteLine("protected method");
        }
        public void Test5()
        {
            Console.WriteLine("public method");
        }

        static void Main(string[] args)
        {
            Specifiers s = new Specifiers();
            s.Test1();
            s.Test2();
            s.Test3();
            s.Test4();
            s.Test5();
        }
    }
}




