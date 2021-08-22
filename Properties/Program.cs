using System;


// Properties are named members of classes, structures and interfaces.
// member variables or methods in a class are called Fields.
// Properties are an extension of fields are are used in the same way 

namespace Properties
{


    class Student {
        private string name = "N.A"; 
        private string code = "Not Known"; 
        private int age = 0;

         // Declare a Code property of type string:
      public string Code {
         get {
            return code;
         }
         set {
            code = value;
         }
      }
      
      // Declare a Name property of type string:
      public string Name {
         get {
            return name;
         }
         set {
            name = value;
         }
      }
      
      // Declare a Age property of type int:
      public int Age {
         get {
            return age;
         }
         set {
            age = value;
         }
    }

    public override string ToString() {
         return "Code = " + Code +", Name = " + Name + ", Age = " + Age;
      }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student s = new Student();
            s.Code = "001";
            s.Name = "Oliver";
            s.Age = 9;

            Console.WriteLine("Student Info: {0}", s); 

            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
        }
    }
}
