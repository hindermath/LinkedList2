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
            DIM list AS IntegerLinkedList = NEW IntegerLinkedList()
            REM Act
            list.AddNode(value)
            REM Assert
            Assert.AreEqual(value, list.Head.Value)
        End Sub
        <TestMethod>
        <DataRow(-1, 2, +3)>
        <DataRow(4, -5, +6)>
        <DataRow(+7, 8, -9)>
        Sub LinkedListMultipleNodesTestSub(value1 As Integer, value2 As Integer, value3 As Integer)
            REM Arrange
            DIM list AS IntegerLinkedList = NEW IntegerLinkedList()
            REM Act
            list.AddNode(value1)
            list.AddNode(value2)
            list.AddNode(value3)
            REM Assert
            Assert.AreEqual(value1, list.Head.Value)
            Assert.AreEqual(value2, list.Head.Next.Value)
            Assert.AreEqual(value3, list.Head.Next.Next.Value)
        End Sub
    End Class

    <TestClass>
    Public Class GenLinkedListTestVb
        <TestMethod>
        <DataRow(1)>
        <DataRow(-2)>
        <DataRow(+3)>
        <DataRow(0)>
        Sub GenLinkedListIntSingleNodeTestSub(value As Integer)
            SingleNodeTestSub(Of Integer)(value)
        End Sub
        <TestMethod>
        <DataRow("A")>
        Sub GenLinkedListStringMultipleNodesCountTestSub(value As String)
            REM Arrange
            DIM genericList AS GenericLinkedList(Of String) = NEW GenericLinkedList(Of String)()
            REM Act
            genericList.AddNode(value)
            REM Assert
            Assert.AreEqual(1, genericList.Count, "The count of nodes in the list is incorrect.")
        End Sub

        Private Sub SingleNodeTestSub(Of T)(value As T)
            REM Arrange
            DIM genericList AS GenericLinkedList(Of T) = NEW GenericLinkedList(Of T)()
            REM Act
            genericList.AddNode(value)
            REM Assert
            Assert.isNotNull(genericList.First, "Head node is null.")
            If genericList.First isNot Nothing Then
                Assert.AreEqual(value, genericList.First.Value, "Head node value is incorrect.")
            End If
        End Sub
    End Class
End Namespace

