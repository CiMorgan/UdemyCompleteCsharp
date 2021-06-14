using System;

namespace UdemyCompleteCsharp5
{
    class Program
    {
        public static void Main(string[] args)
        {
            //integers
            int i = 0;
            i = 5;
            Console.WriteLine(i);  //5
            Console.WriteLine(i+3);
            Console.WriteLine(i++); //5 will write i to the console window first and than add 1
            Console.WriteLine(i--); //6 will have the +1 from above, display the new value for i, and then subtract 1 (5)
            Console.WriteLine(++i); //6 adds 1 prior to printing
            Console.WriteLine(--i); //5 subtracts 1 prior to printing
            Console.WriteLine(3*2);
            Console.WriteLine(10/2);
            Console.WriteLine(10%3);
            Console.WriteLine(10+5*2+3);//stll have PEMDAS

            //floats - have decimals - can't use increment / decrements
            Console.WriteLine(5.5f+1.0f);
            Console.WriteLine(10.0f/3.0f);

            //convert float to int - computer ignores anything after decimal
            Console.WriteLine((int)5.99f);  //comes out as 5
            //Math Class
            Console.WriteLine(Math.Abs(-3));
            Console.WriteLine(Math.Abs(-4.66f));
            Console.WriteLine(Math.Round(-2.7f));
            Console.WriteLine(Math.Round(2.2f));
            Console.WriteLine(Math.Ceiling(-2.7f));
            Console.WriteLine(Math.Ceiling(2.2f));
            Console.WriteLine(Math.Floor(-2.7f));
            Console.WriteLine(Math.Floor(2.2f));
            Console.WriteLine(Math.Truncate(-2.7f));
            Console.WriteLine(Math.Truncate(2.2f));
            Console.WriteLine(Math.Min(-1,5));
            Console.WriteLine(Math.Max(-1, 5));

            //strings and such
            string s1 = "Hello";
            string emptyString = "";
            string emptyString2 = string.Empty;
            //strings are immutable - don't modify original string - return a new string
            string s2 = "World!";
            string s3 = s1 + " " + s2;
            Console.WriteLine(s3);

            //strings stored as array of char
            string s4= "abc";
            //System.Char[] s5= new System.Char[]{'a','b','c'};
            //"add to s4 - get new array of char
            s4 += "d";
            //System.Char[] s6= new System.Char[]{'a','b','c,'d'};
            Console.WriteLine(s4);
            string s6 = "abcd";
            Console.WriteLine(s4 == s6);
            Console.WriteLine(s3 == s6);
            Console.WriteLine(string.Equals(s4, s6));
            Console.WriteLine(string.Equals(s3, s6));

            string @if = "Hello \n world";   //the \n is the newline character  @is the verbatum identifier so keyword can be used as a variable
            Console.WriteLine(@if);
            string newIf = @"Hello \n world";  //here @ is used so string is interpreted literally
            Console.WriteLine(newIf);
            string name = "Cindy";
            Console.WriteLine($"My name is {name}.");


        }
    }
}
