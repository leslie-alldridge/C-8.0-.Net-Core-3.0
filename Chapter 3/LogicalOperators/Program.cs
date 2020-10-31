using System;
using static System.Console;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            WriteLine($"AND | a | b ");
            WriteLine($"a | {a & a,-5} | {a & b,-5} ");
            WriteLine($"b | {b & a,-5} | {b & b,-5} ");
            WriteLine();
            WriteLine($"OR | a | b ");
            WriteLine($"a | {a | a,-5} | {a | b,-5} ");
            WriteLine($"b | {b | a,-5} | {b | b,-5} ");
            WriteLine();
            WriteLine($"XOR | a | b ");
            WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");

            // XOR guide https://thedotnetguide.com/xor-exclusive-or-operator-csharp/

            WriteLine($"a & do stuff = {a && DoStuff()}");
            WriteLine($"b & do stuff = {b && DoStuff()}");

            // && can be used to shortcircuit code, in cases where you always assume a piece of code is called
            // it's safest to avoid using these conditional logical operators.

            /* 
            Bitwise and binary shift operators
            */

            int z = 10;
            int x = 6;
            WriteLine($"z = {z}");
            WriteLine($"x = {x}");
            WriteLine($"z & x = {z & x}");
            WriteLine($"z | x = {z | x}");
            WriteLine($"z ^ x = {z ^ x}");

            // 0101 0000 left-shift a by three bit columns
            WriteLine($"z << 3 = {z << 3}");
            // multiply z by 8
            WriteLine($"z * 8 = {z * 8}");
            // 0000 0011 right-shift x by one bit column
            WriteLine($"x >> 1 = {x >> 1}");

            // Miscellaneous operators
            int age = 47;
            // How many operators in the next statement?
            string firstDigit = age.ToString();
            // four
            // = is the assignment operator
            // . is the member access operator
            // () is the invocation operator
            // [] is the indexer access operator


            //Selection statements

            if (args.Length == 0)
            {
                WriteLine("There are no arguments");
            }
            else
            {
                WriteLine("There is at least one argument");
            }
        }

        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff");
            return true;
        }
    }
}
