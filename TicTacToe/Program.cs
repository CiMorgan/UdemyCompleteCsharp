using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static char[] spaces = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag;

        /// <summary>
        /// Draws the game board
        /// </summary>
        static void DrawBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}   |  {1}   |   {2}  ", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}   |  {1}   |   {2}  ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}   |  {1}   |   {2}  ", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("_____|_____|_____");
        }
        /// <summary>
        /// Checks if the game was won, tied, or should continue
        /// </summary>
        static int CheckWin()
        {
            if (spaces[0]==spaces[1] && spaces[1]==spaces[2] //row 1
                || spaces[3] == spaces[4] && spaces[4] == spaces[5] //row 2
                || spaces[6] == spaces[7] && spaces[7] == spaces[8] //row 3
                || spaces[0] == spaces[3] && spaces[3] == spaces[6] //col 1
                || spaces[1] == spaces[4] && spaces[4] == spaces[7] //col 2
                || spaces[2] == spaces[5] && spaces[5] == spaces[8] //col 3
                || spaces[0] == spaces[4] && spaces[4] == spaces[8] //diag 1
                || spaces[2] == spaces[4] && spaces[4] == spaces[6]) //diag 2
            {
                return 1; //someone won
            }
            else if (spaces[0] != '0'
                && spaces[1] != '1'
                && spaces[2] != '2'
                && spaces[3] != '3'
                && spaces[4] != '4'
                && spaces[5] != '5'
                && spaces[6] != '6'
                && spaces[7] != '7'
                && spaces[8] != '8')
            {
                return -1; //tie
            }
            else
            {
                return 0; //game continues
            }
        }
        /// <summary>
        /// Draws an X on the game board
        /// </summary>
        /// <param name="pos"></param>
        static void DrawX(int pos)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
