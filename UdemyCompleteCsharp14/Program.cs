using System;
using Log = System.Diagnostics.Debug;    //alias for longer namespace; the dot is the dot operator 
//dot operator (.) - one namespace or class is a part of another namespace or class

namespace UdemyCompleteCsharp14
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine("Hello World!");
            Log.WriteLine("Hi!");  //alias made code shorter

        }
    }
}
