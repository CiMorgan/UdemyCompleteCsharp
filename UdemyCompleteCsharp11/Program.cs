﻿using System;
using System.Collections.Generic;

namespace UdemyCompleteCsharp11
{
    //class Program   //Arrays
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

    //class Program  //Lists
    //{
    //    static List<int> numbers = new List<int>() { 1, 3, 5, 4, 2 };
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine(numbers.Count);
    //        numbers.Capacity=10; //limits list to 10 elements
    //        numbers.Add(6); //adds 6 to end of list
    //        numbers.Sort();
    //        foreach(int i in numbers)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        Console.WriteLine("Index of element 5 is: " + numbers.BinarySearch(5));
    //        Console.WriteLine(numbers.Contains(3));
    //        Console.WriteLine(numbers.Contains(20));
    //        numbers.Insert(2, 20);
    //        List<int> subList = new List<int>() { 19, 18, 17, 16 };
    //        numbers.InsertRange(3, subList);
    //        bool areNumbersLessThan6 = numbers.TrueForAll(x => x < 6);
    //        Console.WriteLine(areNumbersLessThan6);
    //        numbers.Sort();
    //        numbers.RemoveRange(6, 5);
    //        foreach (int i in numbers)
    //        {
    //            Console.WriteLine(i);
    //        }
    //        bool areNumbersLessThan7 = numbers.TrueForAll(x => x < 7);
    //        Console.WriteLine(areNumbersLessThan7);
    //        numbers.Reverse();
    //        foreach (int i in numbers)
    //        {
    //            Console.WriteLine(i);
    //        }
    //    }
    //}

    class Program //stacks
    {
        public static void Main(string[] args)
        {
            //Stack<string> s = new Stack<string>();
            //s.Push("cat");
            //s.Push("ant");
            //Console.WriteLine("The stack contains " + s.Count + " elements.");
            Console.WriteLine(IsBalanced("{[<>]}"));
            Console.WriteLine(IsBalanced("{[<>)]}"));
            Console.WriteLine(IsBalanced("{(<>]}"));
        }
        //Balanced Bracket Problem

        private static bool IsBalanced(string inputString)
        {
            Stack<char> stackOfClosingBraces = new Stack<char>();
            Stack<char> stackOfOpeningBraces = new Stack<char>();
            foreach (char c in inputString)
            {
                if (c == '}' || c == ']' || c == ')' || c == '>')
                {
                    stackOfClosingBraces.Push(c);
                }
            }
            for(int i = inputString.Length - 1; i >= 0; i--)
            {
                if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(' || inputString[i] == '<')
                {
                    stackOfOpeningBraces.Push(inputString[i]);
                }
            }
            if(stackOfClosingBraces.Count != stackOfOpeningBraces.Count)
            {
                return false;
            }
            while(stackOfClosingBraces.Count != 0)
            {
                char currentClosingBrace = stackOfClosingBraces.Pop(); //remove top char in closing braces stack
                char currentOpeningBrace = stackOfOpeningBraces.Pop(); //remove top char in opening braces stack
                if((currentOpeningBrace == '(' &&  currentClosingBrace == ')') ||
                    (currentOpeningBrace == '[' && currentClosingBrace == ']') ||
                    (currentOpeningBrace == '{' && currentClosingBrace == '}') ||
                    (currentOpeningBrace == '<' && currentClosingBrace == '>'))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
