using Xunit;
using ListSort;
using FluentAssertions;

namespace ListSortingDemoTests;

public class UnitTests
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(1, 1);
    }

    [Fact]
    public void QuickSortList_ReturnsSortedList()
    {
        // Given
        var myListSortingDemo = new ListSortingDemo();
        var unsortedList = new List<int> { 3,7,1,6,-5 };
        var sortedList = new SortedSet<int>(unsortedList).ToList();

        // When
        ListSortingDemo.QuickSortList(unsortedList, 0, unsortedList.Count - 1);

        // Then
        unsortedList.Should().Equal(sortedList, "list was sorted");
        unsortedList.Should().BeInAscendingOrder();
    }

    [Fact]
    public void CreateRandomListWithDuplicates_ReturnsList()
    {
        // Given
        var size = 20;
        var rangeMin = 0;
        var rangeMax = 100;

        // When
        var randomList = ListSortingDemo.CreateRandomListWithDuplicates(size, rangeMin, rangeMax);

        // Then
        randomList.Should().NotBeNullOrEmpty("cannot return null and size is not set to 0");
        randomList.Should().HaveCount(size, "size of {0} is provided as an argument", size);
        randomList.Should().AllSatisfy(x => x.Should().BeInRange(rangeMin, rangeMax, "range was set in arguments"));
    }

    [Fact]
    public void CreateRandomListWithDuplicates_SizeOf0_ReturnsEmptyList()
    {
        // Given
        var size = 0;
        var rangeMin = 0;
        var rangeMax = 100;

        // When
        var randomList = ListSortingDemo.CreateRandomListWithDuplicates(size, rangeMin, rangeMax);

        // Then
        randomList.Should().NotBeNull("returns and empty list");
        randomList.Should().BeEmpty("size of 0 was passed in");
    }
}