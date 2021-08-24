using System;

namespace Classes
{

    class Lines {
        private double length; 

        public Lines() { //constructor
            Console.WriteLine("Object is being created");
            }

        ~Lines() { //Destructor 
        Console.WriteLine("Object is being deleted");
        }

        public void setLength( double len) {
            length = len;
        }

        public double getLength() {
            return length;
        }
    }


// static variables in classes 
// means no matter how many objects are created there is only 
// one copy of the static member 
// static functions can only access static variables.
    class staticVar {
        public static int num;

        public void count() {
            num++;
        }

        public static int getNum() {
            return num;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lines line = new Lines();

            line.setLength(5.36);
            Console.WriteLine("Length of line : {0}", line.getLength());


            //test static class
            staticVar s1 = new staticVar();
            staticVar s2 = new staticVar();

            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();

            Console.WriteLine("Variable num for s1: {0} ", s1.getNum());
            Console.WriteLine("Variable num for s2: {0} ", s2.getNum());
        }
    }
}
