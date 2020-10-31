using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            // while loop - expression checked before proceeding
            // do loop - executes at least once, before checking expression to see if it should continue

            string password = string.Empty;
            int count = 0;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                count++;
            }
            while (password != "test" && count < 10);

            if (count == 10)
            {
                WriteLine("You have been timed out - too many guesses~");
            }
            else
            {
                WriteLine("Correct!");
            }

            // For statement - more succinct and commonly used with an integer counter
            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            // foreach statement

            string[] names = { "Leslie", "Lisa", "Rachel" };

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
