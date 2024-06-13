using System;
using System.Data.Common;
namespace hello
{
    class first{
       public void show(){
        Console.WriteLine("base class");
       }
    }
    class second : first{
        public void show(){
            base.show();      // base keyword  is pass values t o perent class .
            Console.WriteLine("this is derived class of base class ");
        }
    }
    public class Program{
        public static void Main(string[] args)
        {
            // inheritance
            // derived class borrowed properties from base class is called inheritance.
            // derived class extends from based class.
            second s = new second();   // we can access based class using of object of derived class.
            s.show();
            Console.ReadLine();
        }
    }
}