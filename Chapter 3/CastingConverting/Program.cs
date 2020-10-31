using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a; // int can be safely cast into a double
            WriteLine(b);

            double c = 9.8;
            // int d = c;  compiler error cannot convert double to int
            // WriteLine(d);

            int d = (int)c; // we are explicitly casting and understand the decimal point will be trimmed
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            // Converting with the System.Convert type
            // One difference between casting and converting is that converting rounds the double
            // value 9.8 up to 10 instead of trimming the part after the decimal point.
            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            // How does C# round?

            double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            foreach (double n in doubles)
            {
                WriteLine($"ToInt({n}) is {ToInt32(n)} ");
            }

            foreach (double n in doubles)
            {
                WriteLine(format:
                 "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                 arg0: n,
                 arg1: Math.Round(value: n,
                 digits: 0,
                 mode: MidpointRounding.AwayFromZero));
                //  MidpointRounding.AwayFromZero is the primary school rule.
            }

            // Convert to String
            int number = 12;
            WriteLine(number.ToString());

            bool boolean = true;
            WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object me = new object();
            WriteLine(me.ToString());

            // Converting from Binary object to string

            // allocate 128 byte array
            byte[] binaryObject = new byte[128];

            // populate array with random bytes
            (new Random()).NextBytes(binaryObject);

            WriteLine("Binary object as bytes:");

            for (int index = 0; index < binaryObject.Length; index++)
            {
                Write($"{binaryObject[index]:X} "); // x means hexadecimal string
            }
            WriteLine();

            // convert to base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}");


            // parsing from string to numbers/time/date/ etc
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");
            /* By default, a date and time value outputs with the short date and time
                format. You can use format codes such as D to output only the date part using
                long date format. 
            */
            Write("How many eggs are there?");
            int count;
            string input = Console.ReadLine();
            if (int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs");
            }
            else
            {
                WriteLine("Unable to parse input");
            }


        }
    }
}
