Imports System
Imports LibLinkedList2

Module Program
    Sub Main(args As String())
        DIM list AS LinkedList = NEW LinkedList()
        DIM genListInt AS GenLinkedList(Of Integer) = NEW GenLinkedList(Of Integer)()
        DIM genListStr AS GenLinkedList(Of String) = NEW GenLinkedList(Of String)()

        list.AddNode(1)
        list.AddNode(2)
        list.AddNode(3)
        list.PrintList()

        genListInt.AddNode(1)
        genListInt.AddNode(2)
        genListInt.AddNode(3)
        genListInt.PrintList()

        genListStr.AddNode("one")
        genListStr.AddNode("two")
        genListStr.AddNode("three")
        genListStr.PrintList()
    End Sub
End Module
