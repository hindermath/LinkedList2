Imports LibLinkedList2
Imports ExtensionMethods

Module Program
    Sub Main()
        DIM list = NEW IntegerLinkedList()
        DIM genericListInt = NEW GenericLinkedList(Of Integer)()
        DIM genericListStr = NEW GenericLinkedList(Of String)()

        DIM fileWriter = NEW IO.StreamWriter("output.txt")
        Dim stringWriter = New IO.StringWriter()


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
        Console.WriteLine(listAsString)

        genericListStr.AddNode("one")
        genericListStr.AddNode("two")
        genericListStr.AddNode("three")
        genericListStr.PrintList(Console.Out)
        genericListStr.PrintList(fileWriter)
        genericListStr.PrintList(stringWriter)
        listAsString = stringWriter.ToString()
        Console.WriteLine(listAsString)
    End Sub
End Module
