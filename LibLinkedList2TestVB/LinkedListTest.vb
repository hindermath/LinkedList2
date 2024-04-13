Imports LibLinkedList2
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace LibLinkedList2TestVB
    <TestClass>
    Public Class SimpleLinkedListTestVb
        <TestMethod>
        <DataRow(1)>
        <DataRow(-2)>
        <DataRow(+3)>
        Sub LinkedListSingleNodeTestSub(value As Integer)
            REM Arrange
            DIM list = NEW IntegerLinkedList()
            REM Act
            list.AddNode(value)
            REM Assert
            Assert.AreEqual(value, list.First.Value)
        End Sub
        <TestMethod>
        <DataRow(-1, 2, +3)>
        <DataRow(4, -5, +6)>
        <DataRow(+7, 8, -9)>
        Sub LinkedListMultipleNodesTestSub(value1 As Integer, value2 As Integer, value3 As Integer)
            REM Arrange
            DIM list = NEW IntegerLinkedList()
            REM Act
            list.AddNode(value1)
            list.AddNode(value2)
            list.AddNode(value3)
            REM Assert
            Assert.AreEqual(value1, list.First.Value)
            Assert.AreEqual(value2, list.First.Next.Value)
            Assert.AreEqual(value3, list.First.Next.Next.Value)
        End Sub
    End Class

    <TestClass>
    Public Class GenLinkedListTestVb
        <TestMethod>
        Sub CountOfEmptyList()
            REM Arrange
            DIM list = NEW GenericLinkedList(Of Integer)()
            REM Act
            REM Assert
            Assert.AreEqual(0, list.Count, "The count of nodes in the list is incorrect.")
        End Sub
        <TestMethod>
        Sub AddItem()
            REM Arrange
            DIM list = NEW GenericLinkedList(Of Integer)()
            REM Act
            list.AddNode(42)
            REM Assert
            Assert.AreEqual(1, list.Count, "The count of nodes in the list is incorrect.")
            Assert.AreEqual(42, list.ItemAt(0), "The value of the node is incorrect.")
        End Sub
    End Class
End Namespace

