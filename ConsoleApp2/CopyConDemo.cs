using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class CopyConDemo
    {
       // int x;
       // public CopyConDemo(int i)
       // {
       //     x = i;
       // }
       // public CopyConDemo(CopyConDemo obj)
       // {
       //     x = obj.x;
       // }
       //public void display()
       // {
       //     Console.WriteLine(" value of x is " + x);
       // }
       // static void Main()
       // {
       //     CopyConDemo cd1 = new CopyConDemo(10);
       //     cd1.display();
       //     CopyConDemo cd2 = new CopyConDemo(cd1);
       //     cd2.display();
       // }

        static CopyConDemo()
        {
            Console.WriteLine("static constructor is excecuted");
        }
        static void Main(string[]args)
        {
            
        }
    }
}
