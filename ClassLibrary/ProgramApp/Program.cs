using System;
using Classlib;
using static System.Console;

namespace ProgramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            object[] passengers = {
                new FirstClassPassenger {AirMiles = 1_419},
                new FirstClassPassenger {AirMiles = 16_562},
                new BusinessClassPassenger(), 
                new CoachClassPassenger {CarryOnKG = 25.7},
                new CoachClassPassenger{CarryOnKG = 0},
            };


            foreach (object passenger in passengers)
            {
                WriteLine("Hello World");
                decimal flightCost = passenger switch
                {
                    FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
                    FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
                    FirstClassPassenger _ => 2000M,
                    BusinessClassPassenger _ => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger _   => 6500M, 
                    _ => 800M
                };

                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }
                
            
        }
    }
}

