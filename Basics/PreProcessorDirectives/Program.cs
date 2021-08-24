using System;


//C# does not have a preprocessor; however, the directives are processed 
// as if there was one. In C# the preprocessor directives are used to help in conditional compilation. Unlike C and C++ directives, 
// they do not use macros. A preprocessor must be the only instruction on a line


namespace PreProcessorDirectives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #if (DEBUG && !VC_V10)
                Console.WriteLine("DEBUG is defined");
            #elif (!DEBUG && VC_V10)
                Console.WriteLine("VC_V10 is defined");
            #elif (DEBUG && VC_10)
                Console.WriteLine("VC_10 and DEBUG is defined");
            #else 
                Console.WriteLine("DEBUG and VC_V10 are not defined");
            #endif 
            Console.ReadKey();

        }
    }
}
