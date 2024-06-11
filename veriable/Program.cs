using System;

namespace Program;
public class Program{
    public static void Main(string[] args){

         // datatype
    float b =3.4F;
    double d = 3.4;
    Console.WriteLine(b);
    Console.WriteLine(d);
    
         // typecasting
        // two type of typecasting
        // 1.implicite typecasting
        // 2.Explicite typecasting


// 1.Implicite typecasting : type cast automatically into other data type
// i.e.  char to int to long to float to double
    char c= 'a';
    int i = c;   // char is converted into integer i = 97 ascii of a
    double db = c;


// 2.explicite casting  
// i.Example
    int x = (int)3.5;
    Console.WriteLine(x);
    Console.WriteLine(i);
    Console.WriteLine(db);

    Console.ReadLine();
    }
}