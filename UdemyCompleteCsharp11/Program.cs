using System;

namespace UdemyCompleteCsharp11
{
    class Program
    {
        //4 ways to create an array in C#
        static string[] strings = new string[3];
        static string[] strings1 = new string[3] { "dog", "cat", "elephant" };
        static string[] strings2 = new string[] { "dog", "cat", "elephant" };
        static string[] strings3 = { "dog", "cat", "elephant" }; //will need to use the new keyword if initialized later
        public static void Main(string[] args)
        {
            Console.WriteLine(strings[1]);
            Console.WriteLine(strings1[1]);
            Console.WriteLine(strings2[1]);
            Console.WriteLine(strings3[1]);
        }
    }
}
