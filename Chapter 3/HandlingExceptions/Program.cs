using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age? ");

            string input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch (FormatException)
            {
                WriteLine("The age your entered is not a valid number.");
            }
            catch (OverflowException)
            {
                WriteLine("Your age is a valid number format but it is either too big or small.");
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");

            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Initial value: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                }
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed.");
            }
            int max = 500;
            checked
            {
                for (byte i = 0; i < max; i++)
                {
                    WriteLine(i);
                }
            }

        }
    }
}
