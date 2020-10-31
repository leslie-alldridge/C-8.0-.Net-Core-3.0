using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 3;
            int b = a++;
            WriteLine($"a is {a}, b is {b}");

            // ++ operator is a postfix operator so it executes after the assignment
            // therefore, b equals 3

            // if we need to increment before the assignment, use a postfix operator

            int c = 3;
            int d = ++c;
            WriteLine($"c is {c}, d is {d}");

            // Advice is not to use ++ or -- during an assignment statement
            // best to increment separately e.g. c++  d = c;

            int e = 11;
            int f = 3;
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f {e - f}");
            WriteLine($"e * f is {e * f}");
            WriteLine($"e / f is {e / f}");
            WriteLine($"e % f is {e % f}");

            // % is modulo
            // the remainder is called modulus

            double g = 11.0;
            WriteLine($"g is {g:N1}, f is {f}");
            WriteLine($"g / f is {g / f}");

            // Assignment operators
            int p = 6;

            p += 3; // p = p + 3
            p -= 3; // p = p - 3
            p *= 3; // p = p * 3
            p /= 3; // p = p / 3
        }
    }
}
