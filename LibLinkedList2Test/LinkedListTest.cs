// https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
using LibLinkedList2;

namespace LibLinkedList2Test;
[TestClass]
public class LinkedListTest
{
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public void LinkedListSingleNodeTestMethod(int value)
    {
        // Arrange
        LinkedList list = new LinkedList();
        // Act
        list.AddNode(value);
        // Assert
        if (list.Head != null) Assert.AreEqual(value, list.Head.Value);
    }
    [TestMethod]
    [DataRow(1, 2, 3)]
    [DataRow(4, 5, 6)]
    [DataRow(7, 8, 9)]
    public void LinkedListMultipleNodesTestMethod(int value1, int value2, int value3)
    {
        // Arrange
        LinkedList list = new LinkedList();
        // Act
        list.AddNode(value1);
        list.AddNode(value2);
        list.AddNode(value3);
        // Assert
        if (list.Head != null)
        {
            Assert.AreEqual(value1, list.Head.Value);
            Assert.AreEqual(value2, list.Head.Next.Value);
            Assert.AreEqual(value3, list.Head.Next.Next.Value);
        }
    }
}

[TestClass]
public class GenLinkedListTest
{
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public void GenLinkedListIntSingleNodeTestMethod(int value)
    {
        // Arrange
        GenLinkedList<int> genListInt = new GenLinkedList<int>();
        // Act
        genListInt.AddNode(value);
        // Assert
        if (genListInt.Head != null) Assert.AreEqual(value, genListInt.Head.Value);
    }
    [TestMethod]
    [DataRow(1, 2, 3)]
    [DataRow(4, 5, 6)]
    [DataRow(7, 8, 9)]
    public void GenLinkedListIntMultipleNodesTestMethod(int value1, int value2, int value3)
    {
        // Arrange
        GenLinkedList<int> genListInt = new GenLinkedList<int>();
        // Act
        genListInt.AddNode(value1);
        genListInt.AddNode(value2);
        genListInt.AddNode(value3);
        // Assert
        if (genListInt.Head != null)
        {
            Assert.AreEqual(value1, genListInt.Head.Value);
            Assert.AreEqual(value2, genListInt.Head.Next.Value);
            Assert.AreEqual(value3, genListInt.Head.Next.Next.Value);
        }
    }

    [TestMethod]
    [DataRow("one")]
    [DataRow("two")]
    [DataRow("three")]
    public void GenLinkedListStringMultipleNodesTestMethod(string value)
    {
        // Arrange
        GenLinkedList<string> genListStr = new GenLinkedList<string>();
        // Act
        genListStr.AddNode(value);
        // Assert
        if (genListStr.Head != null) Assert.AreEqual(value, genListStr.Head.Value);
    }
    [TestMethod]
    [DataRow("one", "two", "three")]
    [DataRow("four", "five", "six")]
    [DataRow("seven", "eight", "nine")]
    public void GenLinkedListStringMultipleNodesTestMethod(string value1, string value2, string value3)
    {
        // Arrange
        GenLinkedList<string> genListStr = new GenLinkedList<string>();
        // Act
        genListStr.AddNode(value1);
        genListStr.AddNode(value2);
        genListStr.AddNode(value3);
        // Assert
        if (genListStr.Head != null)
        {
            Assert.AreEqual(value1, genListStr.Head.Value);
            Assert.AreEqual(value2, genListStr.Head.Next.Value);
            Assert.AreEqual(value3, genListStr.Head.Next.Next.Value);
        }
    }
}