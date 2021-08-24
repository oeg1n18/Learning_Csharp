using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] balance = new double[10]; 
            balance[0] = 4500.0;

            int [] marks = new int[5] {99, 98, 97, 92, 91};

            // to loop through each element 
            foreach (int j in marks) {
                Console.WriteLine(j);
            }
        }
    }
}
