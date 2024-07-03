using System;

namespace hello
{   
    interface Idata{
        void name();
        void email();
    }
    interface Iaddress{
        void address();
    }
    class sanket:Idata{
        public void name(){
            Console.WriteLine("name is sanket vekariya");
        }
        public void email(){
            Console.WriteLine("email is sanketvekariya237@gmail.com");
        }
    }
    class akshay:Idata,Iaddress{
        public void name(){
            Console.WriteLine("name is akshay vekariya");
        }
        public void email(){
            Console.WriteLine("email is akshayvekariya997@gmail.com");
        }
        public void address(){
            Console.WriteLine("surat, Gujrat");
        }
    }
    class Program{
        public static void Main(string[] args)
        {
            // interface: in c# it is not support multiple inheritence so that 
            // to archive multiple inheritence we need to use interface
            // interface method does not have body
            // interface contains method declaration and implementation done in 
            // corresponding class. you can add more interface in perticular class
            // abstract class contained abstract and non abstract class where interface
            // contains only abstract class
            // inteface -> public  abstract->by defualt.


            Idata[] arr = new Idata[]{
                new akshay(),
                new sanket()
            };
            foreach(Idata i in arr){
                i.name();
                i.email();
            }

            // this is multiple inheritence
            // akshay a  = new akshay();
            // a.name();
            // a.email();
            // a.address();

            Console.ReadLine();
        }
    }
}