using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class MethodOverloding
    {
        public void test()
        {
            Console.WriteLine("1st Method");
        }
        public void test(int i)
        {
            Console.WriteLine("2nd Method");
        }

        public void test(string s)
        {
            Console.WriteLine("3rd Method");
        }
        public void test(string s , int i)
        {
            Console.WriteLine("4th Method");

        }
        public void test(int i ,string s)
        {
            Console.WriteLine("5th Method");
        }
        static void Main(string [] args)
        {
            MethodOverloding p = new MethodOverloding();
            p.test(10);
            //p.test2(10);
            //p.test3("ayush")
        }
    }
}
