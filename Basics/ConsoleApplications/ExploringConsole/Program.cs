using System;

namespace ExploringConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int numberOfApples = 12;
            decimal PricePerApple = 0.35M; 

            Console.WriteLine(
                format: "{0} Apples cost", PricePerApple);
            

            //Interpolated string the dollar sign enables you to directly output the variables
            Console.WriteLine($"{numberOfApples} apples cost {PricePerApple * numberOfApples:C}");



            //Getting the areguemts 
            WriteLine($"There are {args.Length} arguments");

            //to pass arguments to the program 
            // dotnet run arg1 arg2 arg3 ......
            
        }
    }
}
