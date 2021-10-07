using System;

namespace InsertInCenter
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Write("Enter two strings and I will insert one into the other: ");
            var first = Console.ReadLine() ?? "";
            Console.Write("Now enter a second string: ");
            var second = Console.ReadLine() ?? "";

            var firstHalfwayPoint = first.Length / 2;
            
            Console.WriteLine($"Your new string is {first[..firstHalfwayPoint]}{second}{first[firstHalfwayPoint..]}");
        }
    }
}