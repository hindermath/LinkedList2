// See https://aka.ms/new-console-template for more information
using LibLinkedList2;

SimpleLinkedList list = new SimpleLinkedList();
GenericLinkedList<int> genericListInt = new GenericLinkedList<int>();
GenericLinkedList<string> genericListStr = new GenericLinkedList<string>();

list.AddNode(1);
list.AddNode(2);
list.AddNode(3);
list.PrintList();

genericListInt.AddNode(1);
genericListInt.AddNode(2);
genericListInt.AddNode(3);
genericListInt.PrintList();

genericListStr.AddNode("one");
genericListStr.AddNode("two");
genericListStr.AddNode("three");
genericListStr.PrintList();
