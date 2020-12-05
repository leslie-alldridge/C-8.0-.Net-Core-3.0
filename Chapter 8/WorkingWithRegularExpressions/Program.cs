using System;
using static System.Console;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace WorkingWithRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your age: ");
            string input = ReadLine();

            var ageChecker = new Regex(@"^\d+$");

            if (ageChecker.IsMatch(input))
            {
                WriteLine("thank you!");
            }
            else
            {
            WriteLine($"This is not a valid age: {input}");
            }

            // splitting complex string
            string films =  "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
            string [] filmsDumb = films.Split(',');

            WriteLine("Dumb attempt at splitting:");
            foreach (string film in filmsDumb)
            {
                WriteLine(film);
            }

            var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
            MatchCollection filmsSmart = csv.Matches(films);
            WriteLine("Smart attempt at splitting:");
            foreach (Match film in filmsSmart)
            {
                WriteLine(film.Groups[2].Value);
            }

            var email = "leslie.alldridge@test.com";
            var brokenEmail = "heya";

            var result = EmailIsValid(email);
            var failResult = EmailIsValid(brokenEmail);
            WriteLine($"result: {result}, second result: {failResult}");
        }

        static bool EmailIsValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                WriteLine(m);
                return true;
            }
            catch (FormatException)
            {
                WriteLine("Invalid Format");
                return false;
            }
        }
    }
}
