using System;

namespace UdemyCompleteCsharp4
{
    class Program
    {
        //static void Main()   //Main method - where C# programs start
        //{
        //    System.Diagnostics.Debug.WriteLine("Hello World");
        //}

        public static void Main(String[] args)   //allow Main() method to accept command line arguments
        {
            int x = 5;
            float y = 3.14f;
            string strX = "Hello World!";
            char charX = 'a';
            bool boolX = false;
            System.Diagnostics.Debug.WriteLine(x);
            System.Diagnostics.Debug.WriteLine(y);
            System.Diagnostics.Debug.WriteLine(strX);
            System.Diagnostics.Debug.WriteLine(charX);
            System.Diagnostics.Debug.WriteLine(boolX);
        }
    }
}
