using System;
using System.Diagnostics;

namespace UdemyCompleteCsharp10pt2
{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Animal dog = new Dog();
    //        dog.Run(5);
    //    }



    //}
    //public abstract class Animal
    //{
    //    public abstract void Run(int speed);
    //}

    //public class Dog : Animal
    //{
    //    public override void Run(int speed)
    //    {
    //        Console.WriteLine("The dog is running at speed: " + speed);
    //    }
    //}

    class Program2
    {
        public static void Main(string[] args)
        {
            BaseClass childClass = new ChildClass();
            childClass.PrintMessage();
        }
    }

    class BaseClass
    {
        public virtual void PrintMessage()
        {
            Debug.WriteLine("Hello World!");
        }
    }

    class ChildClass : BaseClass
    {
        public override void PrintMessage()
        {
            Debug.WriteLine("Goodbye World!");
            base.PrintMessage();
        }
    }
}
