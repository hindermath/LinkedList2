using System.Diagnostics;
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