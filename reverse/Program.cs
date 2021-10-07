using System;
using System.Linq;

namespace reverse
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Enter your string and I will reverse it: ");
            var reversedChars = (Console.ReadLine() ?? "").Reverse();
            Console.WriteLine(string.Join("", reversedChars));
        }
    }
}