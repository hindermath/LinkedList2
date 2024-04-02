Imports LibLinkedList2
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace LibLinkedList2TestVB
    <TestClass>
    Public Class LinkedListTest
        <TestMethod>
        <DataRow(1)>
        <DataRow(-2)>
        <DataRow(+3)>
        Sub TestSub(value As Integer)
            REM Arrange
            DIM list AS SimpleLinkedList = NEW SimpleLinkedList()
            REM Act
            list.AddNode(value)
            REM Assert
            Assert.AreEqual(value, list.Head.Value)
        End Sub
    End Class
End Namespace

