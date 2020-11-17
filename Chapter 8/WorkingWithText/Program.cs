using System;
using static System.Console;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long.");
            WriteLine($"First char is {city[0]} and third is {city[2]}.");

            // splitting a string
            string cities = "Paris,Berlin,Madrid,New York";

            string[] citiesArray = cities.Split(',');
            foreach (string cityName in citiesArray)
            {
                WriteLine(cityName);
            };
        }
    }
}
