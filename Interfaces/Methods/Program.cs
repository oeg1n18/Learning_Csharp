using System;

namespace Methods
{

    // Just like C++
    class NumberManipulator {
        public int FindMax(int num1, int num2) {
            return num1 > num2? num1 : num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200; 
            int ret; 
            NumberManipulator n = new NumberManipulator();

            ret = n.FindMax(a,b);
            Console.WriteLine("Max value is {0}", ret);
            Console.ReadLine();
        }
    }
}
