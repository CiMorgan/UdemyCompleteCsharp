using System;

namespace UdemyCompleteCsharp9
{
    //public class Example
    //{
    //    int exampleNumber;
    //    string exampleName;

    //    public Example(int num)
    //    {
    //        exampleNumber = num;
    //    }

    //    public Example(int num, string name)
    //    {
    //        exampleNumber = num;
    //        exampleName = name;
    //    }
    //    //finalizer used by garbage collector when class is destroyed
    //    //~Example(){}

    //    public static void Main(string[] args)
    //    {
    //        Example ex = new Example(5);
    //        Example ex2 = new Example(3, "John");
    //        Console.WriteLine(ex.exampleNumber);
    //        Console.WriteLine(ex2.exampleName+" has "+ex2.exampleNumber+" Bitcoins.");
    //    }

    //}
    //public class Program
    //{
    //    //public string Id { get; set; } //autoimplemented property - get and set with no special syntax
    //    //just get - read only;  just set - write only; both get and set - both read and write
    //    //attributes put in [] above target
    //    private string id;
    //    public string Id
    //    {
    //        get
    //        {
    //            return id;
    //        }
    //        set
    //        {
    //            id = value;
    //        }
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Program program = new Program();
    //        program.Id = "1234";
    //        Console.WriteLine(program.Id);
    //    }
    //}

    //anonymous functions and lambda expressions
    //public class Example
    //{
    //    public static void Main(string[] args)
    //    {
            //        Action debug = () => Console.WriteLine("Hello World!");  //=> lambda operator
            //        debug();

            //        Action multiDebug = () =>
            //        {
            //            Console.WriteLine("Many hello's!");
            //            Console.WriteLine("Many hello's!");
            //            Console.WriteLine("Many hello's!");
            //        };
            //        multiDebug();

            //        Action<string> specName = (s) => Console.WriteLine("Hello "+s);
            //        specName("Cindy");

            //        //Func delegate
            //        Func<int, int, int> multiply = (x, y) => { return x * y; }; //Func<input type, input type,..., return type>
            //        Console.WriteLine(multiply(3,2));
    //    }
    //}
    public class Example
    {
        //Overloading - need different parameters; use method in multiple ways (allows polymorphism)
        //alter number, type, and order of parameters
        void Ex() { }
        void Ex(int number) { }
        void Ex(int num1, int num2) { }
        void Ex(int num, string str) { }
        void Ex(string str, int num) { }
    }

}
