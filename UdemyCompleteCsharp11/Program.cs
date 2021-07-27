using System;
using System.Collections.Generic;

namespace UdemyCompleteCsharp11
{
    //class Program
    //{
    //    //4 ways to create an array in C#
    //    static string[] strings = new string[3];
    //    static string[] strings1 = new string[3] { "dog", "cat", "elephant" };
    //    static string[] strings2 = new string[] { "dog", "cat", "elephant" };
    //    static string[] strings3 = { "dog", "cat", "elephant" }; //will need to use the new keyword if initialized later
    //    public static void Main(string[] args)
    //    {
    //        strings1[1] = "not cat";
    //        Array.Sort(strings2);
    //        Console.WriteLine(strings[1]);
    //        Console.WriteLine(strings1[1]);
    //        Console.WriteLine(strings2[1]);
    //        Console.WriteLine(strings3[1]);
    //        foreach(string str in strings2)
    //        {
    //            Console.WriteLine(str);
    //        }
    //    }
    //}

    class Program
    {
        static List<int> numbers = new List<int>() { 1, 3, 5, 4, 2 };
        public static void Main(string[] args)
        {
            Console.WriteLine(numbers.Count);
            numbers.Capacity=10; //limits list to 10 elements
            numbers.Add(6); //adds 6 to end of list
            numbers.Sort();
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Index of element 5 is: " + numbers.BinarySearch(5));
            Console.WriteLine(numbers.Contains(3));
            Console.WriteLine(numbers.Contains(20));
            numbers.Insert(2, 20);
            List<int> subList = new List<int>() { 19, 18, 17, 16 };
            numbers.InsertRange(3, subList);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
