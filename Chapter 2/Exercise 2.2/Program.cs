using System;
using System.Collections.Generic;

namespace Exercise_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list to store rows we need to output to console
            List<string> rows = new List<string>();

            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "Type", "Byte(s) of memory", "Min", "Max"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "===", "===", "===", "==="));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "sbyte", $"{sizeof(sbyte)}", $"{sbyte.MinValue:N0}", $"{sbyte.MaxValue:N0}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "byte", $"{sizeof(byte)}", $"{byte.MinValue:N0}", $"{byte.MaxValue:N0}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "short", $"{sizeof(short)}", $"{short.MinValue:N0}", $"{short.MaxValue:N0}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "ushort", $"{sizeof(ushort)}", $"{ushort.MinValue:N0}", $"{ushort.MaxValue:N0}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "int", $"{sizeof(int)}", $"{int.MinValue:N0}", $"{int.MaxValue:N0}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "uint", $"{sizeof(uint)}", $"{uint.MinValue:N0}", $"{uint.MaxValue:N0}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "long", $"{sizeof(long)}", $"{long.MinValue:N0}", $"{long.MaxValue:N0}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "ulong", $"{sizeof(ulong)}", $"{ulong.MinValue:N0}", $"{ulong.MaxValue:N0}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "float", $"{sizeof(float)}", $"{float.MinValue}", $"{float.MaxValue}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "double", $"{sizeof(double)}", $"{double.MinValue}", $"{Math.Round(double.MaxValue)}"));
            rows.Add(String.Format("|{0,9}|{1,-17}|{2,-26}|{3,-26}|", "decimal", $"{sizeof(decimal)}", $"{Math.Round(decimal.MinValue)}", $"{decimal.MaxValue:N0}"));

            foreach (string row in rows)
            {
                // Write to console
                Console.WriteLine(row);
            }
        }
    }
}
