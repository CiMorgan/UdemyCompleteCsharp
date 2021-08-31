using System;

namespace UdemyCompleteCsharp12
{
    class Program
    {
        delegate void Print();
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Preprocessor Directive");
            #endregion
            Print helloWorld = HelloWorld;
            helloWorld();
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
