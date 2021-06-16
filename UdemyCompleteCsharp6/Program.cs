using System;

namespace UdemyCompleteCsharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine(date);
            TimeSpan span = new TimeSpan(1, 2, 0); //equivalent to TimeSpan.Zero if ()
            Console.WriteLine(span.Hours);
            Console.WriteLine(span.Minutes);
            Console.WriteLine(span.Seconds);
            Console.WriteLine(span.Milliseconds);
        }
    }
}
