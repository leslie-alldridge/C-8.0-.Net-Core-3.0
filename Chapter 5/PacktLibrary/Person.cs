using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        // constants
        public const string Species = "Homo Sapien";

        // read only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors
        public Person()
        {
            // set default values for fields
            // including read only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Banana", Number: 4);
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        public string OptionalParams(
            string command = "Run!",
            double number = 0.00,
            bool active = true
        )
        {
            return string.Format(
                format: "command is {0}, number is {1} and active is {2}",
                arg0: command,
                arg1: number,
                arg2: active
            );
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            // We passed in 10, 20, 30
            // Result 10, 21, 100

            // out params cannot have a default
            // AND must be initialized inside the method
            z = 99;

            // increment each param
            x++;
            y++;
            z++;

            /*
            When passing a variable as a parameter by default, its current value gets
            passed, not the variable itself. Therefore, x is a copy of the a variable. The
            a variable retains its original value of 10. When passing a variable as a ref
            parameter, a reference to the variable gets passed into the method.

            Therefore, y is a reference to b. The b variable gets incremented when the
            y parameter gets incremented. When passing a variable as an out parameter,
            a reference to the variable gets passed into the method.

            Therefore, z is a reference to c. The c variable gets replaced by whatever
            code executes inside the method. We could simplify the code in the Main
            method by not assigning the value 30 to the c variable, since it will always
            be replaced anyway.
            */
        }
    }
}
