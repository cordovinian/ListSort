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

        Console.WriteLine("Hash based solution to de-duplicate:");
        var listAsHash = new HashSet<int>();
        foreach (var item in sourceList)
        {
            listAsHash.Add(item);
        }
        foreach (var item in listAsHash)
        {
            Console.Write("{0}, ", item);
        }
    }
}