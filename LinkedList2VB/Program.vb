Imports LibLinkedList2
Imports ExtensionMethods

Module Program
    Sub Main()
        DIM list AS IntegerLinkedList = NEW IntegerLinkedList()
        DIM genericListInt AS GenericLinkedList(Of Integer) = NEW GenericLinkedList(Of Integer)()
        DIM genericListStr AS GenericLinkedList(Of String) = NEW GenericLinkedList(Of String)()

        DIM fileWriter AS System.Io.StreamWriter = NEW System.IO.StreamWriter("output.txt")
        Dim stringWriter As System.IO.StringWriter = New System.IO.StringWriter()


        list.AddNode(1)
        list.AddNode(2)
        list.AddNode(3)
        list.PrintList(Console.Out)
        list.PrintList(fileWriter)
        list.PrintList(stringWriter)

        genericListInt.AddNode(1)
        genericListInt.AddNode(2)
        genericListInt.AddNode(3)
        genericListInt.PrintList(Console.Out)
        genericListInt.PrintList(fileWriter)
        genericListInt.PrintList(stringWriter)
        DIM listAsString AS String = stringWriter.ToString()

        genericListStr.AddNode("one")
        genericListStr.AddNode("two")
        genericListStr.AddNode("three")
        genericListStr.PrintList(Console.Out)
        genericListStr.PrintList(fileWriter)
        genericListStr.PrintList(stringWriter)
        listAsString = stringWriter.ToString()
    End Sub
End Module
