using System;

internal class ListSortingDemo
{
    private static void Main(string[] args)
    {
        var sourceList = new List<int> { -1, 4, 3, 2, 1, 1, 2, 3, 4 };

        Console.WriteLine("Easiest solution using LINQ built-ins");

        Console.WriteLine("Source list:");
        Console.WriteLine(string.Join(",", sourceList));

        Console.WriteLine("Resulting list:");
        Console.WriteLine(string.Join(",", sourceList.Distinct().Order()));
    }
}