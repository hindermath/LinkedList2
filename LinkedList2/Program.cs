// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using LibLinkedList2;
using ExtensionMethods;

var list = new IntegerLinkedList();
var genericListInt = new GenericLinkedList<int>();
var genericListStr = new GenericLinkedList<string>();

var fileWriter = new StreamWriter("output.txt");
var stringWriter = new StringWriter();
var debugWriter = TextWriter.Synchronized(Debugger.IsAttached ? new StringWriter() : new StreamWriter(Stream.Null));

list.AddNode(1);
list.AddNode(2);
list.AddNode(3);
list.PrintList(Console.Out);
list.PrintList(fileWriter);

genericListInt.AddNode(1);
genericListInt.AddNode(2);
genericListInt.AddNode(3);
genericListInt.PrintList(Console.Out);
genericListInt.PrintList(fileWriter);
genericListInt.PrintList(stringWriter);
var listAsString = stringWriter.ToString();
Console.WriteLine(listAsString);
genericListInt.PrintList(debugWriter);
var debugOutput = debugWriter.ToString();
Console.WriteLine(debugOutput);

genericListStr.AddNode("one");
genericListStr.AddNode("two");
genericListStr.AddNode("three");
genericListStr.PrintList(Console.Out);
genericListStr.PrintList(fileWriter);
genericListStr.PrintList(stringWriter);
listAsString = stringWriter.ToString();
Console.WriteLine(listAsString);
genericListStr.PrintList(debugWriter);
debugOutput = debugWriter.ToString();
Console.WriteLine(debugOutput);