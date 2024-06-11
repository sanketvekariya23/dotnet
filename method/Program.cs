using System;
using System.Runtime.CompilerServices;
namespace hello{
    public class Program{

        static int average(int a , int b, int c){
            return (a+b+c)/3;
        }
        static int average(int a , int b){
            return (a+b)/2;
        }

        // method overloading same name of methods but different arguments is called methodoverloading
        public static void Main(string[] args)
        {
            // methods/..
            String aa = Console.ReadLine();
            String bb = Console.ReadLine();
            String cc = Console.ReadLine();
            int a = Convert.ToInt32(aa);
            int b = Convert.ToInt32(bb);
            int c = Convert.ToInt32(cc);

            double av = average(a,b,c);

            int d = 32;
            int e = 32;
            average(d,e);
            Console.WriteLine(av);
            Console.ReadLine();
        }
    }
}