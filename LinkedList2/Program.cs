// See https://aka.ms/new-console-template for more information
using LibLinkedList2;

LinkedList list = new LinkedList();
GenLinkedList<int> genListInt = new GenLinkedList<int>();
GenLinkedList<string> genListStr = new GenLinkedList<string>();

list.AddNode(1);
list.AddNode(2);
list.AddNode(3);
list.PrintList();

genListInt.AddNode(1);
genListInt.AddNode(2);
genListInt.AddNode(3);
genListInt.PrintList();

genListStr.AddNode("one");
genListStr.AddNode("two");
genListStr.AddNode("three");
genListStr.PrintList();
