using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Inheritance2 : Inheritance1
    {
        public Inheritance2() : base(10)
        {
            Console.WriteLine("Constructor child class");
        }
        //public  void Test3()
        //{
        //    Console.WriteLine("method 3");
        //}
       static void Main(string[]args)
        {
            //Object obj = new Object();
            //Console.WriteLine(obj.GetType());
            //    Inheritance2 i1 = new Inheritance2();
            //Console.WriteLine(i1.GetType());
            //Inheritance1 i2 = new Inheritance1();
            //Console.WriteLine(i2.GetType());
            //i.Test1();
            //i.Test2();
            //i.Test3();
            Inheritance2 i3 = new Inheritance2();

        }
    }
}
