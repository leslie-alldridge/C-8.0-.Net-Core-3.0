using System.Collections.Generic;
using System;
using System.Collections.Immutable;

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

            // using immutable namespace
            var immutableCities = cities.ToImmutableList();
            var newList = immutableCities.Add("Rio");
            Console.Write("Immutable list of cities");

            foreach (string city in immutableCities)
            {
                Console.Write(city);
            }

            Console.Write("New list of cities:");
            foreach (string city in newList)
            {
                Console.Write(city);
            }
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
