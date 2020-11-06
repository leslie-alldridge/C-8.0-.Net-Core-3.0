using System;

namespace PrimeFactors
{
    class Program
    {
        static string PrimeFactors(int number)
        {
            string result = string.Empty;

            // take out the 2's
            while (number % 2 == 0)
            {
                result += "2 ";
                number /= 2;
            }

            // take out the other primes
            int factor = 3;
            while (factor * factor <= number)
            {
                if (number % factor == 0)
                {
                    // this is a factor
                    result += factor.ToString() + " ";
                    number /= factor;
                }
                else
                {
                    // go to the next odd number
                    factor += 2;
                }
            }

            // if number is not 1, whatever left is a prime
            if (number > 1) result += number.ToString() + " ";
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter an integer: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int userNumber))
            {
                Console.Write(PrimeFactors(userNumber));
            }
            else
            {
                Console.WriteLine("Please enter an integer only.");
            }
        }
    }
}
