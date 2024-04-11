Imports LibLinkedList2
Imports ExtensionMethods

Module Program
    Sub Main(args As String())
        DIM list AS IntegerLinkedList = NEW IntegerLinkedList()
        DIM genericListInt AS GenericLinkedList(Of Integer) = NEW GenericLinkedList(Of Integer)()
        DIM genericListStr AS GenericLinkedList(Of String) = NEW GenericLinkedList(Of String)()

        list.AddNode(1)
        list.AddNode(2)
        list.AddNode(3)
        list.PrintList(Console.Out)

        genericListInt.AddNode(1)
        genericListInt.AddNode(2)
        genericListInt.AddNode(3)
        genericListInt.PrintList(Console.Out)

        genericListStr.AddNode("one")
        genericListStr.AddNode("two")
        genericListStr.AddNode("three")
        genericListStr.PrintList(Console.Out)
    End Sub
End Module
