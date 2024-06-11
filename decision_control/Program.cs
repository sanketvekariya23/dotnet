using System;
using System.Linq.Expressions;

namespace Program{
    public class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your age..!");
            String age1 =Console.ReadLine();
            int age = Convert.ToInt32(age1);

            // if else else if ladder

            if(age<18){
                Console.WriteLine("you are not eligible");
            }
            else if(age>=18 && age !<80){
                Console.WriteLine("you can drive on national highway");
            }
            else if(age>80){
                Console.WriteLine("you can not drive on NH");
            }
            else{
                Console.WriteLine("please provide vaalid input / you can not drive");
            }

            // switch case

            Console.WriteLine("enter number");
            string num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            switch(number){
                case 1:
                Console.WriteLine("monday");
                break;
                case 2:
                Console.WriteLine("tuesday");
                break;
                case 3:
                Console.WriteLine("wenesday");
                break;
                case 4:
                Console.WriteLine("thurday");
                break;
                case 5:
                Console.WriteLine("friday");
                break;
                case 6:
                Console.WriteLine("saturday");
                break;
                case 7:
                Console.WriteLine("sunday");
                break;    
                default :
                Console.WriteLine("you  have  enterd  invalid  input..");
                break;
    
            }
              
            //   Loop - while dowhile for 

            int i=0;
            // while(i<10){
            //     Console.WriteLine(i);
            //     i++;
            // }

            int j=0;
            do{
                Console.WriteLine(j+1);
            }while(j>100);

            for(int k=0; k<10; k++){
                Console.WriteLine(k);
            }

            Console.ReadLine();
        }
    }
 }