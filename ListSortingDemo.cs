using System;

internal class ListSortingDemo
{
    private static void Main(string[] args)
    {
        var sourceList = new List<int> { -1, 4, 3, 2, 1, 1, 2, 3, 4 };

        Console.WriteLine("Source list:");
        Console.WriteLine(string.Join(", ", sourceList));

        Console.WriteLine("Easiest solution using LINQ built-ins:");
        Console.WriteLine(string.Join(", ", sourceList.Distinct().Order()));

        Console.WriteLine("Use a HashSet to de-duplicate:");
        var listAsHash = new HashSet<int>();
        foreach (var item in sourceList)
        {
            listAsHash.Add(item);
        }
        Console.WriteLine(string.Join(", ", listAsHash));

        Console.WriteLine("Use a SortedSet to order and de-duplicate:");
        var listAsSortedSet = new SortedSet<int>();
        foreach (var item in sourceList)
        {
            listAsSortedSet.Add(item);
        }
        Console.WriteLine(string.Join(", ", listAsSortedSet));
    }
}