// https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
using LibLinkedList2;

namespace LibLinkedList2Test;
[TestClass]
public class LinkedListTest
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
}

[TestClass]
public class GenLinkedListTest
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
        GenLinkedList<T> genList = new GenLinkedList<T>();
        // Act
        genList.AddNode(value);
        // Assert
        Assert.IsNotNull(genList.Head, "Head node is null.");
        if (genList.Head != null) Assert.AreEqual(value, genList.Head.Value, "Head node value is incorrect.");
    }
    private void MultipleNodesTestMethod<T>(T value1, T value2, T value3)
    {
        // Arrange
        GenLinkedList<T> genList = new GenLinkedList<T>();
        // Act
        genList.AddNode(value1);
        genList.AddNode(value2);
        genList.AddNode(value3);
        // Assert
        Assert.IsNotNull(genList.Head, "Head node is null.");
        if (genList.Head != null)
        {
            Assert.AreEqual(value1, genList.Head.Value, "Head node value is incorrect.");
            Assert.AreEqual(value2, genList.Head.Next.Value, "Second node value is incorrect.");
            Assert.AreEqual(value3, genList.Head.Next.Next.Value, "Third node value is incorrect.");
        }
    }
    private void ArrayMultipleNodesTestMethod<T>(T[] values)
    {
        // Arrange
        GenLinkedList<T> genList = new GenLinkedList<T>();
        // Act
        foreach (T value in values)
        {
            genList.AddNode(value);
        }
        // Assert
        Assert.IsNotNull(genList.Head, "Head node is null.");
        if (genList.Head != null)
        {
            Node<T> current = genList.Head;
            foreach (var value in values)
            {
                Assert.AreEqual(value, current.Value, $"Node value {value} is incorrect.");
                current = current.Next;
            }
        }
    }
}