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
            DIM list AS SimpleLinkedList = NEW SimpleLinkedList()
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
            DIM list AS SimpleLinkedList = NEW SimpleLinkedList()
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
            DIM genList AS GenLinkedList(Of String) = NEW GenLinkedList(Of String)()
            REM Act
            genList.AddNode(value)
            REM Assert
            Assert.AreEqual(1, genList.Count, "The count of nodes in the list is incorrect.")
        End Sub

        Private Sub SingleNodeTestSub(Of T)(value As T)
            REM Arrange
            DIM genList AS GenLinkedList(Of T) = NEW GenLinkedList(Of T)()
            REM Act
            genList.AddNode(value)
            REM Assert
            Assert.isNotNull(genList.Head, "Head node is null.")
            If genList.Head isNot Nothing Then
                Assert.AreEqual(value, genList.Head.Value, "Head node value is incorrect.")
            End If
        End Sub
    End Class
End Namespace

