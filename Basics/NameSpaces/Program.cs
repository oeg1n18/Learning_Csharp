using System;


// anamespace is designed for providing a way to keep one set of 
// names separate from another. The class names declared in one amespace does not conflict 
// with the same from another 

// the using namespace directive tells the compiler of the areas in which it 
// can look for items. 

using first_space;
using second_space; 


namespace first_space {
    class class1{
        public void func(){
            Console.WriteLine("Im in the first space");
        }
    }
}



namespace second_space {
    class class2{
        public void func() {
            Console.WriteLine("I;m in the second space");
        }
    }
}

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            class1 obj1 = new class1();
            class2 obj2 = new class2();
            obj1.func();
            obj2.func();
        }
    }
}
