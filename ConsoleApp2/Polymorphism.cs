using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Polymorphism
    {
        public virtual void  test1()
        {
            Console.WriteLine("parent class method test 1");
        }
        public void test2()
        {
            Console.WriteLine("parent class method test 2");
        }

    }

    class LoadParent : Polymorphism
    {
        public override void test1()
        {
            Console.WriteLine("child class method test 1");
        }
        public new void Test2()
        {
            Console.WriteLine("child class method test 2");
        }
        static void Main()
        {
            LoadParent c = new LoadParent();
            c.test1();
            c.test2();
            //Console.WriteLine();
        }
    }

}
