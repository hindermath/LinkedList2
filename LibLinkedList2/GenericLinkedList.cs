// Purpose: Contains the GenericLinkedList class and the Node class. The GenericLinkedList class represents a generic linked list. The Node class represents a node in a generic linked list.
namespace LibLinkedList2;

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
    public GenericLinkedListNode<T>? Head { get; set; }

    /// <summary>
    /// The tail node of a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the linked list.</typeparam>
    public GenericLinkedListNode<T>? Tail { get; set; }

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
        Head = null;
        Tail = null;
        Count = 0;
    }

    /// <summary>
    /// Adds a new node with the specified value to the end of the linked list.
    /// </summary>
    /// <typeparam name="T">The type of the value of the node.</typeparam>
    /// <param name="value">The value of the node to be added.</param>
    public void AddNode(T value)
    {
        var newNode = new GenericLinkedListNode<T>(value);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Count++;
    }
    public void AddNodeO1(T value)
    {
        var newNode = new GenericLinkedListNode<T>(value);

        if (Head == null)
        {
            Head = newNode;
            Tail = Head;
        }
        else
        {
            Tail!.Next = newNode;
            Tail = newNode;
        }
        Count++;
    }
}
