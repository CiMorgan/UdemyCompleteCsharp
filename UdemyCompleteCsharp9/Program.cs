using System;

namespace UdemyCompleteCsharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RevRot("563000655734469485", 4)); 
        }

        public static string RevRot(string strng, int sz)
        {
            string answer = "";
            int flag = 1;
            string second = strng;
            int strLength = strng.Length;

            while (flag == 1)
            {

                if (strLength < sz)
                {
                    flag = 0;
                }

                else
                {
                    string first = second.Substring(0, sz);
                    second = second.Substring(sz);
                    strLength = second.Length;
                    int value = 0;
                    for (int i = 0; i < sz; i++)
                    {
                        int num = (int)Char.GetNumericValue(first[i]);
                        value = value + num * num * num;
                    }
                    if (value % 2 == 0)
                    {
                        string reverse = "";
                        foreach (char c in first)
                        {
                            reverse = c + reverse;
                        }
                        answer = answer + reverse;
                    }
                    else
                    {
                        string shift = first.Substring(1) + first[0];
                        answer = answer + shift;
                    }
                }

            }
            return answer;
        }
    }
}
