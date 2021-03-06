using System;
using System.Collections.Generic;

//namespaces used to avoid name conflicts
//using statements import namespaces
namespace UdemyCompleteCsharp4
{
    //C# code goes inside classes
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
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(strX);
            Console.WriteLine(charX);
            Console.WriteLine(boolX);

            bool complete = false;
            if (complete)
            {
                x = 66;
            }
            Console.WriteLine(x); //if complete true, prints 66. otherwise prints 5 (original value of x)

            //for loop
            List<string> collection = new List<string>() { "a", "b", "c" };
            for (int i=0; i<collection.Count; i++)
            {
                Console.WriteLine(collection[i]);
            }

            //while loop
            int j = 3;  
            while (j > 0)
            {
                Console.WriteLine("Loading");
                j--;
            }
            PrintHi();
            PrintMessage("Hello World!");
            //Modulus (%)- remainder of division
            Console.WriteLine(5%4);
            //increment and decrement operator
            int number = 66;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);
            bool b = "abc" is string;
            Console.WriteLine(b);
            Ex2 ex2object = new Ex2();
            bool c = ex2object is Ex1;
            Console.WriteLine(c);
            string s1 = "abc";
            object obj1 = s1;
            string s2 = obj1 as string;  //use as operator to cast obj1 to string
            Console.WriteLine(s2 is string);
            //ternary operator
            int xx = 17;
            int yy = 23;
            var answer = xx > yy ? "x is bigger" : "y is bigger";
            Console.WriteLine(answer);
            //null-collascing operator (??)
            object obj2 = "here";
            object obj3 = obj2 ?? new object();
            Console.WriteLine(obj3);
            //sizeof()
            Console.WriteLine(sizeof(char));
            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(decimal));
            Console.WriteLine(sizeof(bool));
            //typeof()
            Console.WriteLine(typeof(int));
            Console.WriteLine(typeof(char));
            Console.WriteLine(typeof(bool));
            Console.WriteLine(typeof(string));
            //overload + operator
            Box box1 = new Box(2, 2, 2);
            Box box2 = new Box(2, 2, 2);
            Box box3 = box1 + box2;
            Console.WriteLine(box3.GetLength()*box3.GetWidth()*box3.GetHeight());
          



            //single line comment
            /*
             * multi
             * line
             * comment
             */
            ///<summary>
            ///XML documentation comment
            ///</summary>
            //Syntax - rules for how you format the code you type
        }

        //needs to be static in order to call it inside the static main method
        static void PrintHi()
        {
            Console.WriteLine("Hi");
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public class Ex1 { }
        public class Ex2 : Ex1 { }  //any Ex2 object is an Ex1 object (inheritance)

        public class Box
        {
            private int length;
            private int width;
            private int height;

            public Box(int length, int width, int height)
            {
                this.length = length; //"this" keyword - referencing class member variables 
                this.width = width;
                this.height = height;
            }

            public int GetLength()
            {
                return length;
            }
            public int GetWidth()
            {
                return width;
            }
            public int GetHeight()
            {
                return height;
            }
            public static Box operator +(Box box1, Box box2)
            {
                return new Box(box1.GetLength() + box2.GetLength(),
                               box1.GetWidth() + box2.GetWidth(),
                               box1.GetHeight() + box2.GetHeight());
            }
        }






        
       
    }
}
