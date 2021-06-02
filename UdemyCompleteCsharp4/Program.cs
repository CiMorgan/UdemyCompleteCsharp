using System;
using System.Collections.Generic;

namespace UdemyCompleteCsharp4
{
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

            //single line comment
            /*
             * multi
             * line
             * comment
             */
            ///<summary>
            ///XML documentation comment
            ///</summary>
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

        /*Errors
         * 1. Syntax errors - typed something wrong
         * 2. Logic errors - code runs but does something unexpected
         * 3. Runtime errors - happens while program is running
         */
    }
}
