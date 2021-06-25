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
            Console.Clear();//dd
            Console.WriteLine("Press combo");

            //ReadKey() obtain key presses like shift, escape, etc.. and key press combos
            ConsoleKeyInfo keyInfo;
            Console.TreatControlCAsInput = true;    //Control C does not terminiate program and exit the Console (Control C normally closses console)

            do
            {
                keyInfo = Console.ReadKey();
                if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                    Console.WriteLine("ALT+");
                if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                    Console.WriteLine("SHIFT+");
                if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                    Console.WriteLine("CONTROL+");

            } while (keyInfo.Key != ConsoleKey.Escape);

        }
    }
}
