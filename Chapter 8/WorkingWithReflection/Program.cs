﻿using System;
using System.Reflection;
using static System.Console;
using System.Linq;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Assembly metadata: ");
            Assembly assembly = Assembly.GetEntryAssembly();
            WriteLine($" Full Name: {assembly.FullName}");
            WriteLine($" Location: {assembly.Location}");

            var attributes = assembly.GetCustomAttributes();
            WriteLine("Attributes: ");
            foreach (Attribute a in attributes)
            {
                WriteLine($" {a.GetType()}");
            }

            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();

            WriteLine($" Version: {version.InformationalVersion}");

            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();

            WriteLine($" Company: {company.Company}");

            WriteLine();

            WriteLine($"* Types: ");
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                if (!type.Name.Contains("<>"))
                {
                    WriteLine();
                    WriteLine($"Type: {type.FullName}");
                    MemberInfo[] members = type.GetMembers();
                    foreach (MemberInfo member in members)
                    {
                        WriteLine("{0}: {1} ({2})", arg0: member.MemberType, arg1: member.Name, arg2: member.DeclaringType.Name);

                        var coders = member.GetCustomAttributes<CoderAttribute>().OrderByDescending(c => c.LastModified);

                        foreach (CoderAttribute coder in coders)
                        {
                            WriteLine(coder.Coder);
                            WriteLine($" -> Modified by {coder.Coder} on {coder.LastModified.ToShortDateString()}");
                        }
                    }
                }
                else
                {
                    WriteLine("Generated attribute detected!!!!!");
                }
            }
        }

        [Coder("Mark Price", "22 August 2019")]
        [Coder("Leslie Alldridge", "22 June 2020")]
        public static void DoStuff()
        {

        }
    }
}
