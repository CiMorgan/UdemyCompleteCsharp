using System;
using System.Collections.Generic;

//namespaces used to avoid name conflicts
//using statements import namespaces
namespace UdemyCompleteCsharp4
{
    //C# code goes inside classes
    class Program
    {
        //static void Main()   //Main method - where C# programs start
        //{
        //    System.Diagnostics.Debug.WriteLine("Hello World");
        //}

        public static void Main(String[] args)   //allow Main() method to accept command line arguments
        {
            int x = 5;
            float y = 3.14f;
            string strX = "Hello World!";
            char charX = 'a';
            bool boolX = false;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(strX);
            Console.WriteLine(charX);
            Console.WriteLine(boolX);

            bool complete = false;
            if (complete)
            {
                x = 66;
            }
            Console.WriteLine(x); //if complete true, prints 66. otherwise prints 5 (original value of x)

            //for loop
            List<string> collection = new List<string>() { "a", "b", "c" };
            for (int i=0; i<collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }

            //while loop
            int j = 3;  
            while (j > 0)
            {
                Console.WriteLine("Loading");
                j--;
            }
            PrintHi();
            PrintMessage("Hello World!");
            //Modulus (%)- remainder of division
            Console.WriteLine(5%4);
            //increment and decrement operator
            int number = 66;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);
            bool b = "abc" is string;
            Console.WriteLine(b);
            Ex2 ex2object = new Ex2();
            bool c = ex2object is Ex1;
            Console.WriteLine(c);

            //single line comment
            /*
             * multi
             * line
             * comment
             */
            ///<summary>
            ///XML documentation comment
            ///</summary>
            //Syntax - rules for how you format the code you type
        }

        //needs to be static in order to call it inside the static main method
        static void PrintHi()
        {
            Console.WriteLine("Hi");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public class Ex1 { }
        public class Ex2 : Ex1 { }  //any Ex2 object is an Ex1 object (inheritance)



        
       
    }
}
