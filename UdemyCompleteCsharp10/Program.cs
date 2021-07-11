using System;

namespace UdemyCompleteCsharp10
{
    class Program : IExample, ISecondExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Example()
        {
            Console.WriteLine("Hello World");
        }

        public int Example2(int n)
        {
            return 1;
        }

        public string Example3(string str1, string str2)
        {
            return str1 + " " + str2;
        }
    }
    interface IExample   //C# convention to begin interfaces with I
    {
        void Example();  //includes method signature but not method itself
        int Example2(int n);
        string Example3(string str1, string str2);
    }

    interface ISecondExample { }
}
