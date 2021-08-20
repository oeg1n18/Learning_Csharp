using System;

namespace Operator_Overloading
{
    
    class Box {
        private double length;
        private double breadth; 
        private double height;

        public double getVolume() {
            return length * breadth * height;
        }

        public void setLength (double len) {
            length = len;
        }

        public void setBreadth (double bre) {
            breadth = bre;
        }

        public void setHeight( double hei ) {
            height = hei;
        }


        public static Box operator+ (Box b, Box c) {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Box Box1 = new Box();
            Box Box2 = new Box();

            double volume = 0.0;

            Box1.setLength(6.0);
            Box1.setBreadth(7.0);
            Box1.setHeight(2.3);

            Box2.setLength(6.0);
            Box2.setBreadth(7.0);
            Box2.setHeight(2.3);

            volume = Box1.getVolume();

            Box Box3 = Box1 + Box2;

            double volume2 = Box3.getVolume();

            
        }
    }
}
