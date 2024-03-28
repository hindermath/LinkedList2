using LibLinkedList2;

namespace LibLinkedList2Test;

[TestClass]
public class LinkedListTest
{
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public void LinkedListTestMethod(int value)
    {
        // Arrange
        LinkedList list = new LinkedList();
        // Act
        list.AddNode(value);
        // Assert
        if (list.Head != null) Assert.AreEqual(value, list.Head.Value);
    }
}

[TestClass]
public class GenLinkedListTest
{
    [TestMethod]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(3)]
    public void GenLinkedListIntTestMethod(int value)
    {
        // Arrange
        GenLinkedList<int> genListInt = new GenLinkedList<int>();
        // Act
        genListInt.AddNode(value);
        // Assert
        if (genListInt.Head != null) Assert.AreEqual(value, genListInt.Head.Value);
    }

    [TestMethod]
    [DataRow("one")]
    [DataRow("two")]
    [DataRow("three")]
    public void GenLinkedListStrTestMethod(string value)
    {
        // Arrange
        GenLinkedList<string> genListStr = new GenLinkedList<string>();
        // Act
        genListStr.AddNode(value);
        // Assert
        if (genListStr.Head != null) Assert.AreEqual(value, genListStr.Head.Value);
    }
}