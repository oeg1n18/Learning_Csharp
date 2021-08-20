using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            bool T =  true;   //True or False
            byte bin = 3; // 8 bit unsigned binary number
            char A = 'A'; // 16-bit unicode character
            decimal dec = 0.001M; // 128-bit precise decimlal values 28-29s.f
            double dub = 3/2; // 64-bit double-precision floating point tpe
            float floating_num = 0.00001F; //32-bit single-precision floating point type
            int integer = 3; // 32-bit signed integer type
            long long_int = 1000000; // 32-bit 
            sbyte shorter_int = 122; // 8-bit signed integer type
            short short_int = 12; //16-bit signed integer type
            uint shortish_int = 12; //32-bit unsigned int
            ulong long_unsigned = 28; //64-bit unsigned integer type
            ushort short_unsigned = 32; //16-bit unsigned integer type 

            bool boolconversion = Convert.ToBoolean(bin);
            byte byteconversion = Convert.ToByte(bin);
            char charconversion = Convert.ToChar(bin);
            decimal decconversion = Convert.ToDecimal(floating_num);
            double doubleconversion = Convert.ToDouble(floating_num);
            short shot_intconversion = Convert.ToInt16(shorter_int);
            long long_intconversion = Convert.ToInt64(shortish_int);
            float small_float_conversion = Convert.ToSingle(floating_num);
            uint uintconversion = Convert.ToUInt16(shortish_int);

            {
                
            }
        }
    }
}
