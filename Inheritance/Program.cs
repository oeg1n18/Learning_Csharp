using System;

namespace Inheritance
{

    class Shape {
        public void setWidth(int w) {
            width = w;
        }

        public void setHeight(int h) {
            height = h;
        }

        protected int width;
        protected int height;
    }


    class Rectangle: Shape {
        public int getArea() {
            return (width * height);
        }

    }


    // -============ C# does not support multiple inheritance ====================
    // ===== You can use interfaces to implement it ================================

    public interface PaintCost {
        int getCost(int area);
    }

    class Rect: Shape, PaintCost {
        public int getArea(){
            return (width * height); 
        }

        public int getCost(int area) {
            return area * 70;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rect R = new Rect();
            int area; 

            R.setWidth(5);
            R.setHeight(7);
            area = R.getArea();

            Console.WriteLine("Total area: {0}", R.getArea());
            Console.WriteLine("Total paint cost: ${0}", R.getCost(area));

        }
    }
}
