using System;

namespace UdemyCompleteCsharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //if else if else
            int m = 5;
            int n = 5;
            if (m < n)
            {
                Console.WriteLine("m is less than n");
            }
            else if (m > n)
            {
                Console.WriteLine("m is greater than n");
            }
            else
            {
                Console.WriteLine("m is equal to n");
            }

            //switch
            int value = 4;
            switch(value)
            {
                case 1:
                    Console.WriteLine("The value is 1.");
                    break;
                case 2:
                    Console.WriteLine("The value is 2.");
                    break;
                case 3:
                    Console.WriteLine("The value is 3.");
                    break;
                case 4:
                    Console.WriteLine("The value is 4.");
                    break;
                case 5:
                    Console.WriteLine("The value is 5.");
                    break;
                default:
                    Console.WriteLine("It is not 1 thru 5");
                    break;
            }
            //for loops
            for (int i=0; i<5; i++)
            {
                Console.WriteLine("Hello World!");
            }
            string example = "abc";
            for (int i=0; i< example.Length; i++)
            {
                Console.WriteLine(example[i]);
            }
            for (int i = example.Length-1; i >= 0 ; i--)
            {
                Console.WriteLine(example[i]);
            }

            AddNumbers();

        }
        public static void AddNumbers()
        {
            int x = 0;
            for (int i = 1; i < 100; i++)
            {
                x = x + i;
            }
            Console.WriteLine(x);
        }
    }
}
