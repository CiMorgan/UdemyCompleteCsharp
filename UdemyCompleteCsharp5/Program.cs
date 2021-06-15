using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCompleteCsharp5
{
    class Program
    {
        public static void Main(string[] args)
        {
            //integers
            int i = 0;
            i = 5;
            Console.WriteLine(i);  //5
            Console.WriteLine(i+3);
            Console.WriteLine(i++); //5 will write i to the console window first and than add 1
            Console.WriteLine(i--); //6 will have the +1 from above, display the new value for i, and then subtract 1 (5)
            Console.WriteLine(++i); //6 adds 1 prior to printing
            Console.WriteLine(--i); //5 subtracts 1 prior to printing
            Console.WriteLine(3*2);
            Console.WriteLine(10/2);
            Console.WriteLine(10%3);
            Console.WriteLine(10+5*2+3);//stll have PEMDAS

            //floats - have decimals - can't use increment / decrements
            Console.WriteLine(5.5f+1.0f);
            Console.WriteLine(10.0f/3.0f);

            //convert float to int - computer ignores anything after decimal
            Console.WriteLine((int)5.99f);  //comes out as 5
            //Math Class
            Console.WriteLine(Math.Abs(-3));
            Console.WriteLine(Math.Abs(-4.66f));
            Console.WriteLine(Math.Round(-2.7f));
            Console.WriteLine(Math.Round(2.2f));
            Console.WriteLine(Math.Ceiling(-2.7f));
            Console.WriteLine(Math.Ceiling(2.2f));
            Console.WriteLine(Math.Floor(-2.7f));
            Console.WriteLine(Math.Floor(2.2f));
            Console.WriteLine(Math.Truncate(-2.7f));
            Console.WriteLine(Math.Truncate(2.2f));
            Console.WriteLine(Math.Min(-1,5));
            Console.WriteLine(Math.Max(-1, 5));

            //strings and such
            string s1 = "Hello";
            string emptyString = "";
            string emptyString2 = string.Empty;
            //strings are immutable - don't modify original string - return a new string
            string s2 = "World!";
            string s3 = s1 + " " + s2;
            Console.WriteLine(s3);

            //strings stored as array of char
            string s4= "abc";
            //System.Char[] s5= new System.Char[]{'a','b','c'};
            //"add to s4 - get new array of char
            s4 += "d";
            //System.Char[] s6= new System.Char[]{'a','b','c,'d'};
            Console.WriteLine(s4);
            string s6 = "abcd";
            Console.WriteLine(s4 == s6);
            Console.WriteLine(s3 == s6);
            Console.WriteLine(string.Equals(s4, s6));
            Console.WriteLine(string.Equals(s3, s6));

            string @if = "Hello \n world";   //the \n is the newline character  @is the verbatum identifier so keyword can be used as a variable
            Console.WriteLine(@if);
            string newIf = @"Hello \n world";  //here @ is used so string is interpreted literally
            Console.WriteLine(newIf);
            string name = "Cindy";
            Console.WriteLine($"My name is {name}.");
            Console.WriteLine(name.Contains("in"));  //Contains method searches for substring within a string - returns bool
            Console.WriteLine(name.Contains("hope"));
            string example = "He is the greatest of all times";
            Console.WriteLine(example.Substring(3)); //index of start of substraing
            Console.WriteLine(example.Substring(3,2));  //index of start and length of substring
            Console.WriteLine("Bobby said \"Go write some code!\"");
            Console.WriteLine("a\\b");//escape sequence for backslash
            //Console.WriteLine("This beeps. \a"); //the \a makes it beeps - alert escape sequence
            Console.WriteLine("Hello \t World!");
            int price1 = 100;
            int price2 = 50;
            Console.WriteLine(string.Format("Item 1 costs {0:c} and item 2 costs {1:C} ", price1, price2));
            float percent = 0.5f;
            Console.WriteLine(string.Format("The task is {0:P} complete.", percent));

            //StringBuilder class need using System.Text
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello World, part 2");
            for (int t=0; t<4; t++)
            {
                stringBuilder.Append(", and again");
            }
            stringBuilder.Append("!");
            string s = stringBuilder.ToString();
            Console.WriteLine(s);
            stringBuilder.Clear();
            s = stringBuilder.ToString();
            Console.WriteLine(s);
            Console.WriteLine("break");
            string str1 = string.Empty;
            string str2 = "Hello World";
            Console.WriteLine(str1.Length);
            Console.WriteLine(str2.Length);
            string str3 = "The quick brown fox jumped over the lazy dog.";
            string[] sArray = str3.Split(' ');
            foreach (string str in sArray)
            {
                Console.WriteLine(str);
            }
            string str4 = null;
            string str5 = "";
            string str6 = string.Empty;
            string str7 = "Hey, I should be false";
            Console.WriteLine(string.IsNullOrEmpty(str4)+ " Should be true");
            Console.WriteLine(string.IsNullOrEmpty(str5) + " Should be true");
            Console.WriteLine(string.IsNullOrEmpty(str6) + " Should be true");
            Console.WriteLine(string.IsNullOrEmpty(str7) + " Should be false");
            //by default booleans can not be null; set as bool?
            bool? nullBool=null;
            bool example2 = false;
            example2 = (2 > 3);
            Console.WriteLine(example2);

            bool flag = false;
            List<int> intList = new List<int> { 1, 2, 3, 4 };
            foreach (int p in intList)
            {
                if (p == 3)
                {
                    flag = true;
                }
            }
            if (flag)
            {
                Console.WriteLine("3 is in the list");
            }
            else
                Console.WriteLine("3 is not in list");

            //Conversions
            int num = 3;
            float f = num; //num is implicitly converted from int to float with no data lose

            float f1 = 1.5f;
            int num1 = (int)f1; //explicit conversion using cast operator()

            //Boxing
            int example3 = 1;
            object o = example3; //int implicitly converted to object
            //Unboxing - retrieving the value
            int example4 = (int)o;
            Console.WriteLine(example4);


        }
    }
}
