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
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(date.ToString("dddd, MMMM dd, yyyy"));
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            Console.WriteLine(date.ToString("MM/dd/yyyy  hh:mm tt"));
            Console.WriteLine(DateTime.UtcNow.ToString("MM/dd/yyyy  hh:mm tt"));
        }
    }
}
