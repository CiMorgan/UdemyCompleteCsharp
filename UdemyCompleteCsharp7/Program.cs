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
            //foreach
            foreach (char c in "Cindy")
            {
                Console.WriteLine(c);
            }
            //while
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine(k);
                k++;
            }
            //do while loop - bool condition check comes after the code block so it is always ran at least once
            int l = 0;
            do
            {
                Console.WriteLine(l);
                l++;
            } while (l < 5);

            //infinite loops - does not have logic that will terminate loop - runs forever
            //int p = 0;
            //while (p < 2)
            //{
            //    Console.WriteLine("Infinite loop since p = 0 always < 2");
            //}

            //break statement other than in switch
            for (int r=1; r<3; r++)
            {
                Console.WriteLine("r is "+r);
                for (int q = 0; q < 20; q++)
                {
                    if (q == 10)
                    {
                        Console.WriteLine("We reached 10...STOP!");
                        break;  //stops current iteration of the loop
                    }
                    Console.WriteLine(q);
                }
            }
            bool condition1 = true;
            bool condition2 = true;

            if (condition1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("2");
            }
            if (condition2)
            {
                Console.WriteLine("3");
            }



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
