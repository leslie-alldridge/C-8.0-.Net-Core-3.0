using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        // methods
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        // static method to multiply
        public static Person Procreate(Person p1, Person p2)
        {
            var baby = new Person
            {
                Name = $"Baby of {p1.Name} and {p2.Name}"
            };

            p1.Children.Add(baby);
            p2.Children.Add(baby);
            // Classes are reference types, meaning a reference to the 
            // baby object stored in memory is added, not a clone of the baby.


            return baby;
        }

        // Operator to "multiply"
        public static Person operator *(Person p1, Person p2)
        {
            return Person.Procreate(p1, p2);
        }

        // instance method to multiply
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
            // "this" means current instance of the class
        }
    }
}
