using System;

namespace UdemyCompleteCsharp12
{
    //class Program
    //{
    //    delegate void Print();
    //    static void Main(string[] args)
    //    {
    //        #region
    //        Console.WriteLine("Preprocessor Directive");
    //        #endregion
    //        Print helloWorld = HelloWorld;
    //        helloWorld();
    //    }

    //    static void HelloWorld()
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}

    class Program
    {
        private static event EventHandler evt;
        //public static void HandleEvent(object sender, EventArgs evtArgs)
        //{
        //    Console.WriteLine("Hello World!"); 
        //}
        public static void Main(string[] args)
        {
            //evt += HandleEvent;
            //evt.Invoke(null, new EventArgs());

            //using lambda
            evt += (sender, evtArgs) =>
            {
                Console.WriteLine("Hello World!");
            };
            evt += (sender, evtArgs) =>
            {
                Console.WriteLine("Goodbye World!");
            };
            evt.Invoke(null, new EventArgs());

        }

        //~Program()
        //{
        //    evt -= HandleEvent;
        //}
    }
}
