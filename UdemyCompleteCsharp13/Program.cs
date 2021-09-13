using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace UdemyCompleteCsharp13
{
    //REGEX - special text string that describes a search pattern
    //used to perform find and replace with strings
    //12 special char:   \  ^  $  .  |  ?  *  + (  )  [  ]
    //used regex101.com
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);
            Console.WriteLine("Does 2 match pattern: " + regex.IsMatch("2"));  // \d is the pattern that matches digits and 2 is a digit ->returns true
            Console.WriteLine("Does a match pattern: " + regex.IsMatch("a"));  //returns false since a is not a digit

            string pattern1 = "(the)";
            Regex regex1 = new Regex(pattern1);
            Console.WriteLine("Does the match pattern: " + regex1.IsMatch("the"));  //true
            Console.WriteLine("Does The match pattern: " + regex1.IsMatch("The"));  //false

            string text = "the quick brown fox jumped over the lazy dog";
            Match match = regex1.Match(text);  //returns first occurance
            Console.WriteLine(match);
            MatchCollection matches = regex1.Matches(text); //collection of Match's
            foreach(Match a in matches)
            {
                Console.WriteLine(a);  //print 2 the's
            }
        }
    }
}
