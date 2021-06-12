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

        }
    }
}
