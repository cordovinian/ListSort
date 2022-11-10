# ListSort

Take a list of random numbers, de-deplicate, and sort it.

## Getting Started

Requires: [dotnet sdk](https://dotnet.microsoft.com/en-us/download)

Execute `dotnet run .` in project root folder.

## Sample Output

```
Random list:
48, 48, -26, 41, 1, -2, -1, 49, 3, 3, 40, 42, 42

Solution #1 - Sort and de-duplicate using the List type built-in methods
-26, -2, -1, 1, 3, 40, 41, 42, 48, 49
Time: 1.241ms

Solution #2 - Use the datatype SortedSet to order and de-duplicate
-26, -2, -1, 1, 3, 40, 41, 42, 48, 49
Time: 0.8934ms

Solution #3 - Use hash to de-duplicate and Quick sort to order
Use a HashSet to de-duplicate:
48, -26, 41, 1, -2, -1, 49, 3, 40, 42
Time: 0.5481ms
Use quick sort to order:
-26, -2, -1, 1, 3, 40, 41, 42, 48, 49
Time: 0.3488ms
Combined Time: 0.8969ms
```
