using System.Collections.Generic;
using System;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");

            Console.WriteLine("Initial List:");
            PrintCities(cities);
            Console.WriteLine($"The first city is {cities[0]} and the last city is {cities[cities.Count - 1]}");

            cities.Insert(0, "Sydney");
            Console.WriteLine("After inserting Sydney at index 0:");
            PrintCities(cities);

            cities.RemoveAt(1);
            cities.Remove("Milan");
            Console.WriteLine("After removing two cities");
            PrintCities(cities);
        }

        static void PrintCities(List<string> cities)
        {
            foreach (string city in cities)
            {
                Console.WriteLine($" {city}");
            }
        }
    }
}
