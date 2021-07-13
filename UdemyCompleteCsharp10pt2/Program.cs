using System;

namespace UdemyCompleteCsharp10pt2
{
    class Program
    {
        
    }
    abstract class Animal
    {
        public abstract void Run(int speed);
    }

    class Dog : Animal 
    {
        public override void Run(int speed)
        {
            Console.WriteLine("The dog is running at speed: " + speed);
        }
    }
}
