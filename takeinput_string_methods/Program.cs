using System;
namespace p3{
    public class Program{
        public static void Main(string[] args)
        {
            // operator
            //  arithmetic operator
            //  assignedment operator
            //  bitwise operator
            // comparasion operator
            //  conditional operator
            //  logical operator

            // math operation
            int maxx  = Math.Max(91,333);
            double sr = Math.Sqrt(23);
            double minn = Math.Min(1,0.5);

            Console.WriteLine(maxx);
            Console.WriteLine(sr);
            Console.WriteLine(minn);
            // lenght of string
            string str = "tum jo aye jindgi me bat bangyi..";
            Console.WriteLine(str.Length);

            // String concatination
            Console.WriteLine(str +" vekamleya.. tujko ambar se pinjare jyada pyare ..udja kahane se suntatu tu hai kha...");
            // Console.WriteLine(string.Concat(str, " paya tuje paya mene, sabse supaya tuje,apna banaya tuje ,nagme sajaya tuje...."));

            string name = Console.ReadLine();
            string enroll_number =Console.ReadLine();
            Console.WriteLine($"hello {name},  how are you..! /n {enroll_number} is your enrollment number ..");

            String str1 ="india won by 7 run against England ";
            Console.WriteLine(str1[2]);
            // Console.WriteLine(str1.IndexOf("india"));

            Console.ReadLine();
        }
    }
}