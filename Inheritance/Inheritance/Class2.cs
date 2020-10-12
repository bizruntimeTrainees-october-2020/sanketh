using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance 
{
    class Class2
    {
        Class2()
        {
            Console.WriteLine("Class2 constructor is called. ");

        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main()
        {
            Class2 c = new Class2();
            c.Test1();
            c.Test2();
            c.Test3();
            Console.ReadLine();

        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
