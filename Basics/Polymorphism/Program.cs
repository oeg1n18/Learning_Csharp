using System;

namespace Polymorphism
{


    // Function overloading 

    class printdata{
    public void print(int i ) {
        Console.WriteLine(i);
    }

    public void print(double i) {
        Console.WriteLine(i);
    }
    
    public void print(string s) {
        Console.WriteLine(s);
    }
    }



    // Dynamic Polymorphism 
    // Abstract classes contain abstract methods, which are implemented by the derived class. 
    // The derived classes have more specialized functionality
    // you cannot create objects of an abstract class it is designed to be inherited.
    // you cannot declare an abstract method outside an abstract class

 
    abstract class Shape {
        public abstract int area();
    }

    class Rectangle: Shape{
        private int length;
        private int width;

        public Rectangle( int a=0, int b=0) {
            length = a;
            width = b;
        }

        public override int area() {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }
    }


    // When you have a function in a class that you want to be iplemented in the inherited class
    // you use virtual functions.
    class S {
        protected int width, height;
        

        public S(int a = 0, int b = 0) {
            width = a; 
            height = b;
        }

        public virtual int area() {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }


    class Rect : S {
        public Rect(int a=0, int b=0):base(a,b) {}

        public override int area () {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }

    class Triangle : S {
        public Triangle(int a =0, int b =0): base(a,b) {}

    public override int area()
    {
        return base.area(); {
            Console.WriteLine("Tiangle class area :");
            return (width * height /2);
        }
    }


class Caller {
    public void CallArea(S sh) {
        int a;
        a = sh.area();
        Console.WriteLine("Area: {0}", a);
    }
}
    


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Caller c = new Caller();
            Rect r = new Rect(10,7);
            Triangle t = new Triangle(10,5);

            c.CallArea(r);
            c.CallArea(t);

        }
    }
}
