using System;
using exception_handling;
namespace hello{
    public class Program{
        public static void Main(string[] args)
        {
            // exeption handling
            try{
                Console.WriteLine("enter two NOS..");
                String a = Console.ReadLine();
                String b = Console.ReadLine();
                int fn = Convert.ToInt32(a);
                int sn = Convert.ToInt32(b);
                double result = fn/sn ;
                Console.WriteLine(result);
                
            }
            catch(Exception e){
                Console.WriteLine(e);
            }
            finally{
                Console.WriteLine("execute complosorry...!");
            }
            // use of throw exception....
           checking c = new checking();
           Console.WriteLine("enter number for check exeption using throws keyword.");
            String First = Console.ReadLine();
            String Second = Console.ReadLine();
            int first = Convert.ToInt32(First);
            int second = Convert.ToInt32(Second);

            try{
            c.check(first , second);
            }
            catch(DivideByZeroException e){
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException e){
                Console.WriteLine(e.Message);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
            }
    }
 }