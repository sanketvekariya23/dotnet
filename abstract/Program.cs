using System;
using System.Security.Cryptography.X509Certificates;
namespace hello
{
    abstract class sportbike
        {
            public abstract void cycle();  // abstract method
            public void minicycle()
            {        // simple methods
                Console.WriteLine("this is a simple method in abstract class");
            }
        }
        class fourweel : sportbike{
            public override void cycle()
            {
                Console.WriteLine("this is body of abstract method");
            }
        }

    class Program
    {
        public static void Main(string[] args)
        {
        // abstraction : abstraction is used to security. abstraction is hide
        // and shows only assential information.
        // abstract class: if any class inherits: abstract class then it needs to override all abstract methods.
        // abstract method: has not body 
        // we can not create abstract class objects.
        fourweel f = new fourweel();
        f.cycle();
        Console.ReadLine();

    }
}
}