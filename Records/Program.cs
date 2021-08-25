using System;


namespace Records
{

    // these properties are like readonly fields that can 
    // be set during instantiation but not changed.
    public class ImmutablePerson
    {
        public string FirstName {get; init;}
        public string LastName {get; init;}
    }


    //To have a completely immutable object 
    public record ImmutableVehicle {
        public int Wheels {get; init;}
        public string Color {get;init;}
        public string Brand {get; init;}
    }

    public class Person {
        int Age; //Private field by defualt
    }

    public record human {
        int Age;// public property equivalent to 
        // public int Age {get; init;}

    }



    //Positional Records an immutable object with constructor

    public record ImmutableAnimal
    {
        string Name;
        string Species;

        public ImmutableAnimal(string name, string species)
        {
            Name = name; 
            Species = species;
        }

        public void Deconstruct(out string name, out string species)
        {
            name = Name; 
            species = Species;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Cannot be changed after being set
            var jeff = new ImmutablePerson {FirstName = "Jeff",
                                            LastName = "Grainge"};


            var car = new ImmutableVehicle
            {
                Brand = "Mazda MX-5 RF",
                Color = "Soul Red Crystal Metallic", 
                Wheels = 4
            };

            var oscar = new ImmutableAnimal("Oscar", "Labrador");
            var (who,what) = oscar; // calls deconstruct method
            Console.WriteLine($"{who} is a {what}");

            


        }
    }
}
