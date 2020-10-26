using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positive whole number
            // including 0
            uint naturalNumber = 23;

            // integer means positive or negative whole number
            // including 0
            int integerNumber = -23;

            // float means single precision floating point
            // f suffix makes a float literal
            float realNumber = 2.3F;

            // double means double precision floating point
            double anotherRealNumber = 2.3; // double literal

            // decimal and binary
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            // check three variables above all have the same value
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{binaryNotation == hexadecimalNotation}");
        }
    }
}
