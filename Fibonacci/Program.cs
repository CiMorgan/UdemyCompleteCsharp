using System;

namespace Fibonacci
{
    class Program
    {
        static int fib(int n)
        {
            if(n == 0 || n == 1)
            {
                return n;
            }

            return fib(n - 1) + fib(n - 2);
        }

        static int fib2(int n)
        {
            if (n==0 || n==1) { return n; }
            int sLast = 0;  //initially set to first term
            int last = 1; //initially set to second term
            int curPos = 2; 

            while (curPos <= n)
            {
                int temp = last;
                last = last + sLast;
                sLast = temp;
                curPos++;
            }
            return last;

        }

        public static void Main(string[] args)
        {
            Console.WriteLine(fib(11));
            Console.WriteLine(fib2(11));
        }
    }
}
