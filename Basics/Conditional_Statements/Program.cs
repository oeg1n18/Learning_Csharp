using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int A = 1; 
            int B = 2; 

            // If statement
            if(A>B) {
                Console.WriteLine("A is larger than B");
            }    else {
                Console.WriteLine("B is larger than A");
            }

            // if the first statement executed is true 
            // The second will be executed otherwise the third will
            int output = A<B? A  : B ;
            Console.WriteLine(output);



        }
    }
}
