using System;
using System.Collections.Generic;
namespace Towers_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        void MoveDisk(int n, Stack<int> tower1, Stack<int> tower2, Stack<int> tower3)
        {
            if(n == 1)
            {
                tower3.Push(tower1.Pop());
                return;

            }
            MoveDisk(n - 1, tower1, tower2, tower3);
            tower3.Push(tower1.Pop());
            MoveDisk(n - 1, tower2, tower3, tower1);
        }
    }
}
