using System;
using static System.Console;

namespace ExceptionHandling
{
    
    // User-Defined Exceptions
    public class TempIsZeroException: Exception {
        public TempIsZeroException(string message): base(message) {
        }
    }

    public class Temperature {
        int temperature = 0;

        public void showTemp() {

            if(temperature == 0) {
                throw (new TempIsZeroException("Zero Temperature found"));
            } else {
                WriteLine("Temperature:{0}", temperature);
            }
        }

        public void HandleAllExceptions() {
                WriteLine(@"Please Enter your age");
                var input = ReadLine(); 

            
                //Catching all exceptions 
                try {
                    int age = int.Parse(input);
                    WriteLine($"You are {age} years old");

                } catch (Exception ex) {
                    WriteLine($"{ex.GetType()} says {ex.Message}");
                }

        }
    }
    
    
    
    
    
    
    
    
    
    
    
    class DivNumbers
    {
        int result; 

        DivNumbers() {
            result = 0;
        }

        public void division(int num1, int num2) {
            try{
                result = num1/num2; 
            } catch (DivideByZeroException e) {
                Console.WriteLine("Excption caught: {0}", e);
            } finally {
                Console.WriteLine("Result: {0}", result);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DivNumbers d = new DivNumbers();
            d.division(25,0);


            Temperature temp = new Temperature();
            try{
                temp.showTemp();

            } catch(TempIsZeroException e) {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        

            temp.HandleAllExceptions();

        }
    }
}
