// https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
using LibLinkedList2;

namespace LibLinkedList2Test;
[TestClass]
public class IntegerLinkedListTest;

[TestClass]
public class GenericLinkedListTest
{
    [TestMethod]
    public void CountOfEmptyList()
    {
        // Arrange
        var genericList = new GenericLinkedList<int>();
        // Act
        // Assert
        Assert.AreEqual(0, genericList.Count, "The count of nodes in the list is incorrect.");
    }

    [TestMethod]
    public void AddItem()
    {
        // Arrange
        var genericList = new GenericLinkedList<int>();
        // Act
        genericList.AddNode(42);
        // Assert
        Assert.AreEqual(1, genericList.Count, "The count of nodes in the list is incorrect.");
        Assert.AreEqual(42, genericList.ItemAt(0), "The value of the node is incorrect.");
    }

    [TestMethod]
    [DataRow(new[] {42, 0815, 4711}, 3)]
    public void AddMultipleItems(IEnumerable<int> values, int expectedCount)
    {
        // Arrange
        var genericList = new GenericLinkedList<int>();
        // Act
        foreach (var value in values)
        {
            genericList.AddNode(value);
        }
        // Assert
        var nodeCount = 0;
        foreach (var value in values)
        {
            Assert.AreEqual(value, genericList.ItemAt(nodeCount), $"The value {value} of node {nodeCount} is incorrect.");
            nodeCount++;
        }
        Assert.AreEqual(expectedCount, nodeCount, "The count of nodes in the list is incorrect.");
    }

    [TestMethod]
    public void CannotGetItemNegativeIndex()
    {
        // Arrange
        var genericList = new GenericLinkedList<int>();
        // Act
        // Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => genericList.ItemAt(-1));
    }

    [TestMethod]
    public void CannotGetItemOfEmptyList()
    {
        // Arrange
        var genericList = new GenericLinkedList<int>();
        // Act
        // Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => genericList.ItemAt(0));
    }

    [TestMethod]
    public void CannotGetItemIndexOutOfBounds()
    {
        // Arrange
        var genericList = new GenericLinkedList<int>();
        // Act
        genericList.AddNode(42);
        // Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => genericList.ItemAt(1));
    }
}