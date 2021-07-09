using System;

namespace UdemyCompleteCsharp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        interface IExample   //C# convention to begin interfaces with I
        {
            void Example();  //includes method signature but not method itself
            int Example2(int n);
            string Example3(string str1, string str2);
        }    
    }
}
