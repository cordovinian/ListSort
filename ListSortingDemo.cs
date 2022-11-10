using System;
using System.Diagnostics;

internal class ListSortingDemo
{
    private static void Main(string[] args)
    {
        var timer = new Stopwatch();
        var sourceList = new List<int>(CreateRandomListWithDuplicates(10, -50, 50));

        Console.WriteLine("Random list:");
        Console.WriteLine(string.Join(", ", sourceList));

        Console.WriteLine("\nSolution #1 - Sort and de-duplicate using the List type built-in methods");
        timer.Start();
        var orderedList = sourceList.Distinct().Order();
        timer.Stop();
        Console.WriteLine(string.Join(", ", orderedList));
        Console.WriteLine("Time: {0}ms", timer.Elapsed.TotalMilliseconds);

        Console.WriteLine("\nSolution #2 - Use the datatype SortedSet to order and de-duplicate");
        var listAsSortedSet = new SortedSet<int>();
        timer.Restart();
        foreach (var item in sourceList)
        {
            listAsSortedSet.Add(item);
        }
        timer.Stop();
        Console.WriteLine(string.Join(", ", listAsSortedSet));
        Console.WriteLine("Time: {0}ms", timer.Elapsed.TotalMilliseconds);

        Console.WriteLine("\nSolution #3 - Use hash to de-duplicate and Quick sort to order");
        Console.WriteLine("Use a HashSet to de-duplicate:");
        var listAsHash = new HashSet<int>();
        timer.Restart();
        foreach (var item in sourceList)
        {
            listAsHash.Add(item);
        }
        timer.Stop();
        var dedupeTime = timer.Elapsed.TotalMilliseconds;
        Console.WriteLine(string.Join(", ", listAsHash));
        Console.WriteLine("Time: {0}ms", dedupeTime);

        Console.WriteLine("Use quick sort to order:");
        timer.Restart();
        List<int> result = QuickSortList(listAsHash.ToList(), 0, listAsHash.Count - 1);
        timer.Stop();
        var sortTime = timer.Elapsed.TotalMilliseconds;
        Console.WriteLine(string.Join(", ", result));
        Console.WriteLine("Time: {0}ms", sortTime);
        Console.WriteLine("Combined Time: {0}ms", dedupeTime + sortTime);
    }

    private static List<int> CreateRandomListWithDuplicates(int distinctSize, int min, int max)
    {
        var random = new List<int>();
        var rand = new Random(DateTime.Now.Second);

        for (int counter = 0; counter < distinctSize; counter++)
        {
            var newNumber = rand.Next(min, max);
            random.Add(newNumber);
            if (newNumber % 3 == 0)
            {
                random.Add(newNumber);
            }
        }

        return random;
    }
    private static List<int> QuickSortList(List<int> sourceList, int leftIndex, int rightIndex)
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