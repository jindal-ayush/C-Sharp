using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Class2
    {
        int x;
        public Class2(int i)
        {
            x = i;
            Console.WriteLine("parametrized constructor = " + i);
        }
        public void display()
        {
            Console.WriteLine("value of x  is = " + x);
        }
        static void Main(string[] args)
        {
            Class2 cd1 = new Class2(10);
            Class2 cd2 = new Class2(20);
            cd1.display();
            cd2.display();

        }

    }
}
