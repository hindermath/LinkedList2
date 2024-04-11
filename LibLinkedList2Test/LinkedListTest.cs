// https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
using LibLinkedList2;

namespace LibLinkedList2Test;
[TestClass]
public class IntegerLinkedListTest
{
    [TestMethod]
    [DataRow(1)]
    [DataRow(-2)]
    [DataRow(+3)]
    public void LinkedListSingleNodeTestMethod(int value)
    {
        // Arrange
        IntegerLinkedList list = new IntegerLinkedList();
        // Act
        list.AddNode(value);
        // Assert
        if (list.First != null) Assert.AreEqual(value, list.First.Value);
    }
    [TestMethod]
    [DataRow(-1, 2, +3)]
    [DataRow(4, -5, +6)]
    [DataRow(+7, 8, -9)]
    public void LinkedListMultipleNodesTestMethod(int value1, int value2, int value3)
    {
        // Arrange
        IntegerLinkedList list = new IntegerLinkedList();
        // Act
        list.AddNode(value1);
        list.AddNode(value2);
        list.AddNode(value3);
        // Assert
        if (list.First != null)
        {
            Assert.AreEqual(value1, list.First.Value);
            Assert.AreEqual(value2, list.First.Next.Value);
            Assert.AreEqual(value3, list.First.Next.Next.Value);
        }
    }

    [TestMethod]
    [DataRow(1, +2, -3)]
    public void LinkedListMultipleNodesCountTestMethod(int value1, int value2, int value3)
    {
        // Arrange
        IntegerLinkedList list = new IntegerLinkedList();
        // Act
        list.AddNode(value1);
        list.AddNode(value2);
        list.AddNode(value3);
        // Assert
        Assert.AreEqual(3, list.Count);
    }
}

[TestClass]
public class GenericLinkedListTest
{
    [TestMethod]
    public void CountOfEmptyList()
    {
        // Arrange
        GenericLinkedList<int> genericList = new GenericLinkedList<int>();
        // Act
        // Assert
        Assert.AreEqual(0, genericList.Count, "The count of nodes in the list is incorrect.");
    }

    [TestMethod]
    public void AddItem()
    {
        // Arrange
        GenericLinkedList<int> genericList = new GenericLinkedList<int>();
        // Act
        genericList.AddNode(42);
        // Assert
        Assert.AreEqual(1, genericList.Count, "The count of nodes in the list is incorrect.");
        Assert.AreEqual(42, genericList.ItemAt(0), "The value of the node is incorrect.");
    }

    [TestMethod]
    [DataRow(new int[] {42, 0815, 4711}, 3)]
    public void AddMultipleItems(IEnumerable<int> values, int expectedCount)
    {
        // Arrange
        GenericLinkedList<int> genericList = new GenericLinkedList<int>();
        // Act
        foreach (var value in values)
        {
            genericList.AddNode(value);
        }
        // Assert
        Assert.AreEqual(expectedCount, genericList.Count, "The count of nodes in the list is incorrect.");
        int index = 0;
        foreach (var value in values)
        {
            Assert.AreEqual(value, genericList.ItemAt(index), $"The value {value} of node {index} is incorrect.");
            index++;
        }
    }

    [TestMethod]
    public void CannotGetItemNegativIndex()
    {
        // Arrange
        GenericLinkedList<int> genericList = new GenericLinkedList<int>();
        // Act
        // Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => genericList.ItemAt(-1));
    }

    [TestMethod]
    public void CannotGetItemOfEmptyList()
    {
        // Arrange
        GenericLinkedList<int> genericList = new GenericLinkedList<int>();
        // Act
        // Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => genericList.ItemAt(0));
    }

    [TestMethod]
    public void CannotGetItemIndexOutOfBounds()
    {
        // Arrange
        GenericLinkedList<int> genericList = new GenericLinkedList<int>();
        // Act
        genericList.AddNode(42);
        // Assert
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => genericList.ItemAt(1));
    }
}