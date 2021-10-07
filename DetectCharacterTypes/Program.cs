using System;
using System.Text.RegularExpressions;

namespace DetectCharacterTypes
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Enter a string for me to count the character types: ");
            var input = Console.ReadLine() ?? "";

            var alpha = Regex.Matches(input, @"[A-z]").Count;
            var numeric = Regex.Matches(input, @"[0-9]").Count;
            var whitespace = Regex.Matches(input, @"\s").Count;
            var other = input.Length - alpha - numeric - whitespace;
            
            Console.WriteLine($"Your string contained {alpha} letters, {numeric} numbers, {whitespace} whitespace characters, and {other} other characters");
        }
    }
}