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
list.PrintList();

genericListInt.AddNode(1);
genericListInt.AddNode(2);
genericListInt.AddNode(3);
genericListInt.PrintList(Console.Out);
genericListInt.PrintList(fileWriter);
genericListInt.PrintList(stringWriter);
var listAsString = stringWriter.ToString();
genericListInt.PrintList(debugWriter);
var debugOutput = debugWriter.ToString();

genericListStr.AddNode("one");
genericListStr.AddNode("two");
genericListStr.AddNode("three");
genericListStr.PrintList(Console.Out);
