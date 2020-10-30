using static System.Console;
using System;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"There are {args.Length} arguments.");

            foreach (string arg in args)
            {
                WriteLine(arg);
            }

            if (args.Length < 4)
            {
                WriteLine("Please specify two colors and dimensions. Eg:");
                WriteLine("dotnet run red yellow 80 40");
                return;
            }

            var forgroundValue = args[0];
            var backgroundValue = args[1];
            var height = args[2];
            var width = args[3];


            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: forgroundValue,
                ignoreCase: true
            );

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: backgroundValue,
                ignoreCase: true
            );

            WindowHeight = int.Parse(height);
            WindowWidth = int.Parse(width);
        }
    }
}
