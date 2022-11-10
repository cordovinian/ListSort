# ListSort

Take a list of random numbers, de-deplicate, and sort it.

## Getting Started

Requires: [dotnet sdk](https://dotnet.microsoft.com/en-us/download)

Execute `dotnet run --project .\ListSortingDemo\ListSortingDemo.csproj` in project root folder.

## Sample Output

```
Random list:
{ -11, 11, 23, 46, 25, 27, 27, -16, -1, 18 }

Solution #1 - Sort and de-duplicate using the List type built-in methods
{ -16, -11, -1, 11, 18, 23, 25, 27, 46 }
Time: 1.127ms

Solution #2 - Use the datatype SortedSet to order and de-duplicate
{ -16, -11, -1, 11, 18, 23, 25, 27, 46 }
Total Time: 0.807ms

Solution #3 - Use hash to de-duplicate and Quick sort to order
Use a HashSet to de-duplicate:
{ -11, 11, 23, 46, 25, 27, -16, -1, 18 }
Time: 0.786ms
Use quick sort to order:
{ -16, -11, -1, 11, 18, 23, 25, 27, 46 }
Time: 0.280ms
Total Time: 1.067ms
```
