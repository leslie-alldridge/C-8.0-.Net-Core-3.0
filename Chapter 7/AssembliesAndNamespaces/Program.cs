using System;
using static System.Console;
using System.Xml.Linq;
using Packt.Shared;
using DialectSoftware.Collections;
using DialectSoftware.Collections.Generics;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XDocument();
            string s1 = "Hello"; // best practice is to use lowercase "string" so we don't have to import the System namespace
            String s2 = "World";
            WriteLine(s1 + s2);

            var x = new Axis("x", 0, 10, 1);    
            var y = new Axis("y", 0, 4, 1);

            Write("Enter a color value in Hex: ");
            string hex = ReadLine();

            WriteLine("Is {0} a valid color value? {1}", arg0: hex, arg1: hex.IsValidHex());

            Write("Enter a XML tag: ");
            string xmlTag = ReadLine();
            WriteLine("Is {0} a valid XML tag? {1}",
             arg0: xmlTag, arg1: xmlTag.IsValidXmlTag());

            Write("Enter a password: ");
            string password = ReadLine();
            WriteLine("Is {0} a valid password? {1}",
             arg0: password, arg1: password.IsValidPassword());
        }
    }
}
