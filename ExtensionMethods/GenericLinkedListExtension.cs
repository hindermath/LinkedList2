﻿using LibLinkedList2;
namespace ExtensionMethods;

// Extension methods must be defined in a static class.
public static class StringExtension
{
    // This is the extension method.
    // The first parameter takes the "this" modifier
    // and specifies the type for which the method is defined.
    public static int WordCount(this string str)
    {
        return str.Split(new char[] {' ', '.','?'}, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

public static class GenericLinkedListExtension
{
    public static void Print<T>(this GenericLinkedList<T> list, TextWriter writer)
    {
        writer.WriteLine("Start of LinkedList print out:");

        var counter = 0;
        var current = list.First;
        while (current != null)
        {
            writer.WriteLine($"Node at index {counter} has value of type {current.Value.GetType()} and value: {current.Value}");
            current = current.Next;
            counter++;
        }

        writer.WriteLine($"End of LinkedList printout. The linked list has {list.Count} nodes in total.");
    }
}