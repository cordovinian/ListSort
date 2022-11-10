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

        Console.WriteLine("Use the datatype SortedSet to order and de-duplicate:");
        var listAsSortedSet = new SortedSet<int>();
        foreach (var item in sourceList)
        {
            listAsSortedSet.Add(item);
        }
        Console.WriteLine(string.Join(", ", listAsSortedSet));

        Console.WriteLine("Use a HashSet to de-duplicate:");
        var listAsHash = new HashSet<int>();
        foreach (var item in sourceList)
        {
            listAsHash.Add(item);
        }
        Console.WriteLine(string.Join(", ", listAsHash));

        Console.WriteLine("Use quick sort to order:");
        List<int> result = QuickSortList(listAsHash.ToList(), 0, listAsHash.Count - 1);
        Console.WriteLine(string.Join(", ", result));
    }

    public static List<int> QuickSortList(List<int> sourceList, int leftIndex, int rightIndex)
    {
        var pivot = sourceList[leftIndex];
        var left = leftIndex;
        var right = rightIndex;

        while (left <= right)
        {
            while (sourceList[left] < pivot)
            {
                left++;
            }
            while (sourceList[right] > pivot)
            {
                right--;
            }
            if (left <= right)
            {
                int swap = sourceList[left];
                sourceList[left] = sourceList[right];
                sourceList[right] = swap;
                left++;
                right--;
            }
        }
        if (leftIndex < right)
        {
            QuickSortList(sourceList, leftIndex, right);
        }
        if (left < rightIndex)
        {
            QuickSortList(sourceList, left, rightIndex);
        }

        return sourceList;
    }
}