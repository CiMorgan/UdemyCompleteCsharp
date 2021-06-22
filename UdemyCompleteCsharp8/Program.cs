using System;

namespace UdemyCompleteCsharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write you name");
            string uInput = Console.ReadLine();
            Console.WriteLine("My name is "+uInput);

            Console.WriteLine("Hit a key: ");
            int x = Console.Read();   //Read() returns an int
            Console.WriteLine(x);

            //change background of console based on key pressed
            Console.WriteLine("g=green, r=red, b=blue, w=white");
            int y = Console.Read();
            char userInput = Convert.ToChar(y);
            while (userInput != 'z')
            {
                switch (userInput)
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case 'r':
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case 'w':
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }
                Console.Clear();
                Console.WriteLine("g=green, r=red, b=blue, w=white");

                y = Console.Read();
                userInput = Convert.ToChar(y);
            }




        }
    }
}
