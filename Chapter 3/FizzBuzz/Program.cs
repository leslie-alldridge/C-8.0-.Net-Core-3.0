﻿using System;
using static System.Console;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // FizzBuzz attempt
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Write("FizzBuzz, ");
                }
                else if (i % 3 == 0)
                {
                    Write("Fizz, ");
                }
                else if (i % 5 == 0)
                {
                    Write("Buzz, ");
                }
                else
                {
                    Write($"{i}, ");
                }
            }

            /* Worked first time

            1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, 
            Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, 
            34, Buzz, Fizz, 37, 38, Fizz, Buzz, 41, Fizz, 43, 44, FizzBuzz, 46, 47, Fizz, 49, 
            Buzz, Fizz, 52, 53, Fizz, Buzz, 56, Fizz, 58, 59, FizzBuzz, 61, 62, Fizz, 64, 
            Buzz, Fizz, 67, 68, Fizz, Buzz, 71, Fizz, 73, 74, FizzBuzz, 76, 77, Fizz, 79, Buzz, 
            Fizz, 82, 83, Fizz, Buzz, 86, Fizz, 88, 89, FizzBuzz, 91, 92, Fizz, 94, Buzz, Fizz, 
            97, 98, Fizz, Buzz, 
            */


            // Exercise 3.4
            WriteLine(); // breathing space
            try
            {
                WriteLine("Enter a number between 0 and 255:");
                int input = int.Parse(ReadLine());
                WriteLine("Enter another number between 0 and 255:");
                int secondInput = int.Parse(ReadLine());
                WriteLine($"{input} divided by {secondInput} is {input / secondInput}");
            }
            catch (FormatException)
            {
                WriteLine("Please use whole numbers only.");
            }
        }
    }
}
