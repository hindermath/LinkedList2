// Purpose: Contains the GenericLinkedList class and the Node class. The GenericLinkedList class represents
// a generic linked list. The Node class represents a node in a generic linked list.
// Creator: Thorsten Hindermann
// Created: 2024-04-10
// Modified: 2024-04-10
#define PUBLICNODE
namespace LibLinkedList2;
#if PUBLICNODE
/// <summary>
/// Represents a node in a generic linked list.
/// </summary>
/// <typeparam name="T">The type of the value of the node.</typeparam>
public class GenericLinkedListNode<T>
{
    /// <summary>
    /// Represents the value of a node in a generic linked list. The value can be of any type.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    public T Value { get; set; }

    /// <summary>
    /// Represents the next node in a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the value of the next node.</typeparam>
    public GenericLinkedListNode<T>? Next { get; set; }

    /// <summary>
    /// Represents a node in the generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the value of the node.</typeparam>
    public GenericLinkedListNode(T value)
    {
        Value = value;
        Next = null;
    }
}
#endif
/// <summary>
/// Represents a generic linked list.
/// </summary>
/// <typeparam name="T">The type of the elements in the linked list.</typeparam>
public class GenericLinkedList<T>
{
    /// <summary>
    /// Represents the head of a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the linked list.</typeparam>
    #if PUBLICNODE
    public GenericLinkedListNode<T>? First { get; private set; }
    #else
    private Node? First { get; set; }
    #endif

    /// <summary>
    /// The tail node of a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the linked list.</typeparam>
    #if PUBLICNODE
    public GenericLinkedListNode<T>? Last { get; set; }
    #else
    private Node? Last { get; set; }
    #endif

    /// <summary>
    /// Gets the number of nodes in the linked list.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Represents a node in the generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the value of the node.</typeparam>
    public GenericLinkedList()
    {
        First = null;
        Last = null;
        Count = 0;
    }

    /// <summary>
    /// Adds a new node with the specified value to the end of the linked list.
    /// </summary>
    /// <typeparam name="T">The type of the value of the node.</typeparam>
    /// <param name="value">The value of the node to be added.</param>
    public void AddNode(T value)
    {
        #if PUBLICNODE
        var newNode = new GenericLinkedListNode<T>(value);
        #else
        var newNode = new Node(value);
        #endif

        if (First == null)
        {
            First = newNode;
        }
        else
        {
            var current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Count++;
    }

    /// <summary>
    /// Adds a new node with the specified value to the end of the linked list.
    /// This operation has a time complexity of O(1).
    /// </summary>
    /// <typeparam name="T">The type of the value of the node.</typeparam>
    /// <param name="value">The value of the node to be added.</param>
    public void AddNodeO1(T value)
    {
        #if PUBLICNODE
        var newNode = new GenericLinkedListNode<T>(value);
        #else
        var newNode = new Node(value);
        #endif

        if (First == null)
        {
            First = newNode;
            Last = newNode;
        }
        else
        {
            Last!.Next = newNode;
            Last = newNode;
        }
        Count++;
    }

    /// <summary>
    /// Retrieves the element at the specified index in the generic linked list.
    /// </summary>
    /// <param name="index">The zero-based index of the element to retrieve.</param>
    /// <returns>The element at the specified index.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the index is less than 0 or larger than the index of the last element in the list.</exception>
    public T ItemAt(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index must not be negative");
        }

        if (First is null)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index was too large for the list");
        }

        var currentNode = First;
        for (var i = 0; i < index; i++)
        {
            currentNode = currentNode.Next;

            if (currentNode is null)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index was too large for the list");
            }
        }

        return currentNode.Value;
    }

    /// <summary>
    /// Represents a node in the generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the value of the node.</typeparam>
    private sealed class Node
    {
        internal Node(T value)
        {
            Value = value;
        }

        internal T Value { get; }

        internal Node? Next { get; set; }
    }
}
