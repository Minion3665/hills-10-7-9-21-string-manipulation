using System;
using System.Text.RegularExpressions;

namespace StripToIntegers
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Enter a string and I'll give you back just the integers: ");
            Console.WriteLine(Regex.Replace(Console.ReadLine() ?? "", @"\D", ""));
        }
    }
}