using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exception_handling
{
    class checking 
    {
         public void check(int first , int second){
           if(first<0 || second<0) {
            throw new DivideByZeroException("Enter number grater than one..!");
           }
           else if(first == 0 || second ==0){
            throw new IndexOutOfRangeException("Zero not allowed..");
           }
           else{
            Console.WriteLine(" n and m is the " + first + " " + second);
           }
         }
    }
}