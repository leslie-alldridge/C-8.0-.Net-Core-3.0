﻿using System;
using static System.Console;
using Packt.Shared;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            // call instance method
            var baby1 = mary.ProcreateWith(harry);

            // call static method
            var baby2 = Person.Procreate(harry, jill);

            // call an operator
            var baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count} children");
            WriteLine($"{mary.Name} has {mary.Children.Count} children");
            WriteLine($"{jill.Name} has {jill.Children.Count} children");

            WriteLine(
                format: "{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name
            );

            // calling the local function
            WriteLine($"5! is {Person.Factorial(5)}");

            harry.Shout += Harry_Shout;
            int count = 0;
            do
            {
                harry.Poke();
                count++;
            }
            while (count < 4);

            // Comparing objects when sorting

            Person[] people = {
                new Person {Name = "Simon"},
                new Person {Name = "Jenny"},
                new Person {Name = "Adam"},
                new Person {Name = "Richard"},
            };

            WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("User Person's IComparable implementation to sort:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            WriteLine("Use PersonComparer's IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }

            var t1 = new Thing();
            t1.Data = 42;
            WriteLine($"Thing with integer: {t1.Process(42)}");

            var t2 = new Thing();
            t2.Data = "apple";
            WriteLine($"Thing with a string {t2.Process("apple")}");

            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            WriteLine($"GenericThing with an integer: {gt1.Process(42)}");

            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            string number1 = "4";
            WriteLine("{0} squared is {1}", arg0: number1, arg1: Squarer.Square<string>(number1));

            byte number2 = 3;
            WriteLine("{0} squared is {1}", arg0: number1, arg1: Squarer.Square(number2));

            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

            Employee john = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7, 28)
            };
            john.WriteToConsole();

            john.HireDate = new DateTime(2014, 11, 23);
            john.EmployeeCode = "JJ001";
            WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

            WriteLine(john.ToString());

            Employee aliceInEmployee = new Employee { Name = "Alice", EmployeeCode = "AA123", DateOfBirth = new DateTime(1970, 12, 12) };
            Person aliceInPerson = aliceInEmployee;

            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());

            /*
            When a method is overridden with virtual and override, the compiler is smart
            enough to know that although the variable is declared as a Person class, the object
            itself is an Employee class and, therefore, the Employee implementation of ToString
            is called.
            */

            // Explicit casting (safely)
            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an Employee");
                Employee explicitAlice = (Employee)aliceInPerson;
            }
            // can also use `as` keyword and check for null
            Employee aliceAsEmployee = aliceInPerson as Employee;
            if (aliceAsEmployee != null)
            {
                // we can do something with aliceAsEmployee
                WriteLine($"{nameof(aliceInPerson)} AS an Employee");
            }

            try
            {
                aliceInEmployee.TimeTravel(new DateTime(1999, 12, 31));
                aliceInEmployee.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            }

            string email1 = "leslie.alldridge@gmail.com";
            string email2 = "ian&test.com";

            WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email1,
                arg1: StringExtensions.IsValidEmail(email1)
            );
            WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email2,
                arg1: StringExtensions.IsValidEmail(email2)
            );
        }

        private static void Harry_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }
    }
}
