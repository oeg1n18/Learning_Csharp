using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string newstring = " I am a string";
            char []letters = {'H', 'E', 'L', 'L', 'O'};
            // you can create a string from a array of chars
            string greetings = new string(letters);
            Console.WriteLine(greetings);

            string [] sarray= {"Hello", "my", "name", "is","oliver"};
            string message = String.Join(" ", sarray);
            Console.WriteLine(message);

            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);

            //comparing strings
            string str1 = "This is test";
            string str2 = "This is text";

            // see if strings are the same
            if (String.Compare(str1, str2) == 0) {
                Console.WriteLine(str1 + " " + str2 + "are equal.");
            } else { Console.WriteLine(str1 + " and " +str2 + "are not equal");}

            // test for string contains string
            if (str1.Contains("text") ){
                Console.WriteLine("String cotains text");
            }

            //get a substring 
            string substr = str1.Substring(7);
            Console.WriteLine("substring is:  " + substr);

            //joining strings
            str1 = String.Join("I've been added to this string :   ", str1);
            Console.WriteLine(str1);

           
        }
    }
}
