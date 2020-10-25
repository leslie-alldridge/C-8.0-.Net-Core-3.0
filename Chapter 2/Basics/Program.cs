using System.Linq;
using System.Reflection;
using System;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // In line comment

            /* Multi line
            comment
            */
            double heightInMetres = 1.88;
            char symbol = '$';

            // Verbatim string literal used to escape \t
            string filePath = @"C:\televisions\sony\bravia.txt";


            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");
            
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                var a = Assembly.Load(new AssemblyName(r.FullName));
                int methodCount = 0;

                foreach (var t in a.DefinedTypes)
                {
                    methodCount += t.GetMethods().Count();
                }

                Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.",
                arg0: a.DefinedTypes.Count(),
                arg1: methodCount,
                arg2: r.Name);
            }
        }
    }
}
