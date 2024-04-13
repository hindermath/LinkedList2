using LibLinkedList2;
namespace ExtensionMethods;

public static class GenericLinkedListExtension
{
    public static void PrintList<T>(this GenericLinkedList<T> list, TextWriter writer)
    {
        writer.WriteLine("Start of LinkedList print out:");


        for (int counter = 0; counter < list.Count; counter++)
        {
            var node = list.ItemAt(counter);
            writer.WriteLine($"Node at index {counter} has value of type {node.GetType()} and the value: {node}");
        }

        writer.WriteLine($"End of LinkedList printout. The linked list has {list.Count} nodes in total.");
    }

    public static void PrintList(this IntegerLinkedList list, TextWriter writer)
    {
        writer.WriteLine("Start of LinkedList print out:");

        var counter = 0;
        var current = list.First;
        while (current != null)
        {
            writer.WriteLine($"Node at index {counter} has value of type {current.Value.GetType()} and the value: {current.Value}");
            current = current.Next;
            counter++;
        }

        writer.WriteLine($"End of LinkedList printout. The linked list has {list.Count} nodes in total.");
    }
}