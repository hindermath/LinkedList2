Imports System
Imports LibLinkedList2

Module Program
    Sub Main(args As String())
        DIM list AS IntegerLinkedList = NEW IntegerLinkedList()
        DIM genericListInt AS GenericLinkedList(Of Integer) = NEW GenericLinkedList(Of Integer)()
        DIM genericListStr AS GenericLinkedList(Of String) = NEW GenericLinkedList(Of String)()

        list.AddNode(1)
        list.AddNode(2)
        list.AddNode(3)
        REM list.PrintList()

        genericListInt.AddNode(1)
        genericListInt.AddNode(2)
        genericListInt.AddNode(3)
        REM genericListInt.PrintList()

        genericListStr.AddNode("one")
        genericListStr.AddNode("two")
        genericListStr.AddNode("three")
        REM genericListStr.PrintList()
    End Sub
End Module
