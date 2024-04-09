// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using LibLinkedList2;

IntegerLinkedList list = new IntegerLinkedList();
GenericLinkedList<int> genericListInt = new GenericLinkedList<int>();
GenericLinkedList<string> genericListStr = new GenericLinkedList<string>();

var fileWriter = new System.IO.StreamWriter("output.txt");
var stringWriter = new System.IO.StringWriter();
var debugWriter = TextWriter.Synchronized(Debugger.IsAttached ? new StringWriter() : new StreamWriter(Stream.Null));

list.AddNode(1);
list.AddNode(2);
list.AddNode(3);
PrintList(list, Console.Out);

genericListInt.AddNode(1);
genericListInt.AddNode(2);
genericListInt.AddNode(3);
PrintGenericList<int>(genericListInt, Console.Out);
PrintGenericList<int>(genericListInt, fileWriter);
PrintGenericList<int>(genericListInt, stringWriter);
var listAsString = stringWriter.ToString();
PrintGenericList<int>(genericListInt, debugWriter);
var debugOutput = debugWriter.ToString();

genericListStr.AddNode("one");
genericListStr.AddNode("two");
genericListStr.AddNode("three");
PrintGenericList<string>(genericListStr, Console.Out);
PrintGenericList<string>(genericListStr, fileWriter);
PrintGenericList<string>(genericListStr, stringWriter);
listAsString = stringWriter.ToString();
PrintGenericList<string>(genericListStr, debugWriter);
debugOutput = debugWriter.ToString();

return;

void PrintGenericList<T>(GenericLinkedList<T> list, TextWriter writer)
{
    writer.WriteLine("Start of LinkedList print out:");

    var counter = 0;
    var current = list.Head;
    while (current != null)
    {
        writer.WriteLine($"Node at index {counter} has value of type {current.Value.GetType()} and value: {current.Value}");
        current = current.Next;
        counter++;
    }

    writer.WriteLine($"End of LinkedList printout. The linked list has {list.Count} nodes in total.");
}

void PrintList(IntegerLinkedList list, TextWriter writer)
{
    writer.WriteLine("Start of LinkedList print out:");

    var counter = 0;
    var current = list.Head;
    while (current != null)
    {
        writer.WriteLine($"Node at index {counter} has value of type {current.Value.GetType()} and value: {current.Value}");
        current = current.Next;
        counter++;
    }

    writer.WriteLine($"End of LinkedList printout. The linked list has {list.Count} nodes in total.");

}
