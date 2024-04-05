// https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
using LibLinkedList2;

namespace LibLinkedList2Test;
[TestClass]
public class SimpleLinkedListTest
{
    [TestMethod]
    [DataRow(1)]
    [DataRow(-2)]
    [DataRow(+3)]
    public void LinkedListSingleNodeTestMethod(int value)
    {
        // Arrange
        SimpleLinkedList list = new SimpleLinkedList();
        // Act
        list.AddNode(value);
        // Assert
        if (list.Head != null) Assert.AreEqual(value, list.Head.Value);
    }
    [TestMethod]
    [DataRow(-1, 2, +3)]
    [DataRow(4, -5, +6)]
    [DataRow(+7, 8, -9)]
    public void LinkedListMultipleNodesTestMethod(int value1, int value2, int value3)
    {
        // Arrange
        SimpleLinkedList list = new SimpleLinkedList();
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

    [TestMethod]
    [DataRow(1, +2, -3)]
    public void LinkedListMultipleNodesCountTestMethod(int value1, int value2, int value3)
    {
        // Arrange
        SimpleLinkedList list = new SimpleLinkedList();
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
    [DataRow(1)]
    [DataRow(-2)]
    [DataRow(3)]
    [DataRow(0)]
    public void GenLinkedListIntSingleNodeTestMethod(int value)
    {
        SingleNodeTestMethod<int>(value);
    }
    [TestMethod]
    [DataRow(-1, 2, 3)]
    [DataRow(4, -5, 6)]
    [DataRow(7, 8, -9)]
    public void GenLinkedListIntMultipleNodesTestMethod(int value1, int value2, int value3)
    {
        MultipleNodesTestMethod<int>(value1, value2, value3);
    }

    [TestMethod]
    [DataRow(new double[] {1, 2.0, 3.4})]
    [DataRow(new double[] {-4, 5, -6.1})]
    [DataRow(new double[] {7.0, -8.97, 9})]
    public void GenLinkedListDblArrayMultipleNodesTestMethod(double[] values)
    {
        ArrayMultipleNodesTestMethod<double>(values);
    }

    [TestMethod]
    [DataRow("one")]
    [DataRow("two")]
    [DataRow("three")]
    [DataRow("")]
    public void GenLinkedListStringMultipleNodesTestMethod(string value)
    {
        SingleNodeTestMethod<string>(value);
    }

    [TestMethod]
    [DataRow("one")]
    public void GenLinkedListStringMultipleNodesCountTestMethod(string value)
    {
        // Arrange
        GenericLinkedList<string> genericList = new GenericLinkedList<string>();
        // Act
        genericList.AddNode(value);
        // Assert
        Assert.AreEqual(1, genericList.Count, "The count of nodes in the list is incorrect.");
    }

    [TestMethod]
    [DataRow("one", "two", "three")]
    [DataRow("four", "five", "six")]
    [DataRow("seven", "eight", "nine")]
    [DataRow("", "", "")]
    [DataRow("one", "", "nine")]
    public void GenLinkedListStringMultipleNodesTestMethod(string value1, string value2, string value3)
    {
        MultipleNodesTestMethod<string>(value1, value2, value3);
    }
    [TestMethod]
    [DataRow(new string[] {"one", "two", "three"})]
    [DataRow(new string[] {"four", "five", "six"})]
    [DataRow(new string[] {"seven", "eight", "nine"})]
    [DataRow(new string[] {"", "", ""})]
    [DataRow(new string[] {"one", "", "nine"})]
    public void GenLinkedListStringArrayMultipleNodesTestMethod(string[] values)
    {
        ArrayMultipleNodesTestMethod<string>(values);
    }

    private void SingleNodeTestMethod<T>(T value)
    {
        // Arrange
        GenericLinkedList<T> genericList = new GenericLinkedList<T>();
        // Act
        genericList.AddNode(value);
        // Assert
        Assert.IsNotNull(genericList.Head, "Head node is null.");
        if (genericList.Head != null) Assert.AreEqual(value, genericList.Head.Value, "Head node value is incorrect.");
    }
    private void MultipleNodesTestMethod<T>(T value1, T value2, T value3)
    {
        // Arrange
        GenericLinkedList<T> genericList = new GenericLinkedList<T>();
        // Act
        genericList.AddNode(value1);
        genericList.AddNode(value2);
        genericList.AddNode(value3);
        // Assert
        Assert.IsNotNull(genericList.Head, "Head node is null.");
        if (genericList.Head != null)
        {
            Assert.AreEqual(value1, genericList.Head.Value, "Head node value is incorrect.");
            Assert.AreEqual(value2, genericList.Head.Next.Value, "Second node value is incorrect.");
            Assert.AreEqual(value3, genericList.Head.Next.Next.Value, "Third node value is incorrect.");
        }
    }
    private void ArrayMultipleNodesTestMethod<T>(T[] values)
    {
        // Arrange
        GenericLinkedList<T> genericList = new GenericLinkedList<T>();
        // Act
        foreach (T value in values)
        {
            genericList.AddNode(value);
        }
        // Assert
        Assert.IsNotNull(genericList.Head, "Head node is null.");
        if (genericList.Head != null)
        {
            Node<T> current = genericList.Head;
            foreach (var value in values)
            {
                Assert.AreEqual(value, current.Value, $"Node value {value} is incorrect.");
                current = current.Next;
            }
        }
    }
}