using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1954, 12, 22);
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            bob.BucketList = (WondersOfTheAncientWorld)18;
            bob.Children.Add(new Person { Name = "Alfred" });
            bob.Children.Add(new Person { Name = "Suzie" });

            WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth
            );

            WriteLine(
                format: "{0}'s favorite wonder is {1}. It's integer is {2}.",
                arg0: bob.Name,
                arg1: bob.FavoriteAncientWonder,
                arg2: (int)bob.FavoriteAncientWonder
            );

            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

            WriteLine($"Bob has {bob.Children.Count} children.");
            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($"{bob.Children[child].Name}");
            };

            foreach (Person child in bob.Children)
            {
                WriteLine($"Saying hello to {child.Name}!");
            };

            WriteLine($"{bob.Name} is a {Person.Species}");
            WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };

            WriteLine(
                format: "{0} was born on {1:dd MMM yy}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth
            );

            // Bank Accounts
            BankAccount.InterestRate = 0.012M; // storing a shared value
            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate
            );

            var leslieAccount = new BankAccount();
            leslieAccount.AccountName = "Mr. Alldridge";
            leslieAccount.Balance = 100;

            WriteLine(format: "{0} earned {1:C} interest.",
                arg0: leslieAccount.AccountName,
                arg1: leslieAccount.Balance * BankAccount.InterestRate
            );

            var blankPerson = new Person();
            WriteLine(
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantiated
            );

            var gunny = new Person("Gunny", "Mars");

            WriteLine(
                format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: gunny.Name,
                arg1: gunny.HomePlanet,
                arg2: gunny.Instantiated
            );

            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());

            (string, int) fruit = bob.GetFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            var namedFruit = bob.GetNamedFruit();
            WriteLine($"{namedFruit.Name} and {namedFruit.Number} exist");

            var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

            var thing2 = (bob.Name, bob.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children."); // infers Name and Count as the named fields

            // deconstructing tuples
            (string fruitName, int fruitNumber) = bob.GetFruit();
            WriteLine($"Deconstructed {fruitName}, {fruitNumber}");

            WriteLine(bob.SayHello());
            WriteLine(bob.SayHello("Leslie"));

            WriteLine(bob.OptionalParams());
            WriteLine(bob.OptionalParams(command: "Jump", number: 99));
            WriteLine(bob.OptionalParams("Poke!", active: false));

            int a = 10;
            int b = 20;

            WriteLine($"Before: a = {a}, b = {b}, c = doesn't exist");

            bob.PassingParameters(a, ref b, out int c);

            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1992, 6, 9)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            sam.FavouriteIceCream = "Chocolate Fudge";
            WriteLine($"Sam's favourite ice-cream flavour is {sam.FavouriteIceCream}.");

            sam.FavouritePrimaryColor = "Red";
            WriteLine($"Sam's favourite primary color is {sam.FavouritePrimaryColor}");

            sam.Children.Add(new Person { Name = "Charlie" });
            sam.Children.Add(new Person { Name = "Ella" });

            WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");
            WriteLine($"Sam's first child is {sam[0].Name}");
            WriteLine($"Sam's second child is {sam[1].Name}");
        }
    }
}
