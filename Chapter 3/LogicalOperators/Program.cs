using System;
using static System.Console;
using System.IO;

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

            // Pattern matching with if statements

            object o = 3;
            int l = 4;

            if (o is int m)
            {
                WriteLine($"{m} x {l} = {m * l}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

        // Switch statements

        /*
        You can use the goto keyword to jump to another
        case or a label. The goto keyword is frowned upon by most
        programmers but can be a good solution to code logic in some
        scenarios. However, you should use it sparingly.
        */

        A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    WriteLine("one");
                    break;
                case 2:
                    WriteLine("two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("three or four");
                    goto case 1;
                case 5:
                    // go to sleep for half a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            }

            string path = @"C:\Users\Beast\Desktop\C-8.0-.Net-Core-3.0\Chapter 3";

            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            string message = string.Empty;

            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file..";
                    break;
                case MemoryStream ms:
                    message = "The stream is a memory address";
                    break;
                default:
                    message = "The stream is some other type.";
                    break;
                case null:
                    message = "The stream is null";
                    break;
            }

            WriteLine(message);

            // Switch expression format

            string message2 = s switch
            {
                FileStream writeableFile when s.CanWrite
                    => "The stream is a file that I can write to.",
                FileStream readOnlyFile
                    => "The stream is a read-only file.",
                MemoryStream ms
                    => "The stream is a memory address.",
                null
                => "The stream is null.",
                _
                => "The stream is some other type."
            };
            WriteLine(message2);

        }

        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff");
            return true;
        }
    }
}
