using System;

namespace ConsoleApp2
{
    internal class Class1
    {
       public Class1 ()
        {
            Console.WriteLine("Construtor is called");
        }
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Class1 obj2 = new Class1();
            Class1 obj3 = new Class1();
            Console.ReadLine();

        }
    }
}

//using System; // Console ke liye zaruri

//namespace ConsoleApp2
//{
//    internal class Class1
//    {
//        public Class1()
//        {
//            Console.WriteLine("constructor is called");

//        }
//        static void Main(string[] args)
//        {
//            Class1 obj = new Class1();
//            Console.ReadLine();
//        }
//    }
//}
