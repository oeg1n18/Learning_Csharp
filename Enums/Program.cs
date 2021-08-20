using System;

namespace Enums
{
    /* Enumerations are value data type. In other words, enumeration contains its own values and cannot 
    inherit or pass inheritance
    */
    class Program
    {   enum Days {Sun, Mon, Tue, Wed, thu, Fri, Sat};
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine(WeekdayStart);
            Console.WriteLine(WeekdayEnd);


            
        }
    }
}
