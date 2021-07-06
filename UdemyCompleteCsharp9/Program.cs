using System;

namespace UdemyCompleteCsharp9
{
    public class Example
    {
        int exampleNumber;
        string exampleName;

        public Example(int num)
        {
            exampleNumber = num;
        }

        public Example(int num, string name)
        {
            exampleNumber = num;
            exampleName = name;
        }
        //finalizer used by garbage collector when class is destroyed
        //~Example(){}
    
        public static void Main(string[] args)
        {
            Example ex = new Example(5);
            Example ex2 = new Example(3, "John");
            Console.WriteLine(ex.exampleNumber);
            Console.WriteLine(ex2.exampleName+" has "+ex2.exampleNumber+" Bitcoins.");
        }

    }
}
