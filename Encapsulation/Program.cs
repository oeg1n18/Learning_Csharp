﻿using System;

namespace Encapsulation
{

    class Rectangle {

        public double length;
        public double width; 

        public double GetArea() {
            return length * width;
        }

        public void Display() {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            r.length = 4.5; 
            r.width = 2.5; 
            r.Display();
            Console.ReadLine();

        }
    }
}
