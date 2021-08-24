using System;
using System.Text.RegularExpressions;
// A regular expression is a pattern that could be matched against an input text. The .Net 
// Framework proides a regular expression engine that allows such matching. 
// A pattern consists of one or more character literals, operators or constructs

namespace RegularExpressions
{
    class Program
    {
        private static void showMatch(string text, string expr) { 
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach (Match m in mc) {
                Console.WriteLine(m);
            }
        }

    


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string str = "A Thousand Splendid Suns";

            Console.WriteLine("Matching words hat start with 'S': "); 
            showMatch(str, @"\bS\S*"); //matches words that start with s

            str = "make maze and manage to measure it";

            Console.WriteLine("Matching words start with 'm' and ends with 'e'");
            showMatch(str, @"\bm\S*e\b");



            // Replaces extra white space 
            string input = "hello world";
            string pattern = "\\s+";
            string replacement = " ";

            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

        Console.WriteLine("Original string {0}", input);
        Console.WriteLine("Replacement String: {0}", result);
        Console.ReadKey();
        }


    }
}
