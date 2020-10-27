using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object

            Console.WriteLine($"{name} is {height} metres tall.");

            // int length1 = name.Length; // compile error
            int length2 = ((string)name).Length; // telling compiler it's a string

            Console.WriteLine($"{name} has {length2} characters.");

            // dynamic types

            dynamic anotherName = "Ahmed";
            // Compiler doesn't know what type is during build time so errors raise during runtime
            int length = anotherName.Length;
            Console.WriteLine(length);

            // Specifying and inferring the type of a local variable
            var population = 66_000_000; 
            var weight = 1.88;
            var price = 4.99M;
            var fruit = "Apples";
            var letter = 'Z';
            var happy = true;

            // explore default values
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(string) = {default(string)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
        }
    }
}
