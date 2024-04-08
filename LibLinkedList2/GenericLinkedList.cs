// Purpose: Contains the GenericLinkedList class and the Node class. The GenericLinkedList class represents a generic linked list. The Node class represents a node in a generic linked list.
namespace LibLinkedList2;
/// <summary>
/// Represents a node in the generic linked list.
/// </summary>
/// <typeparam name="T">The type of the value of the node.</typeparam>
public class NodeObsolete<T>
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
    public NodeObsolete<T>? Next { get; set; }

    /// <summary>
    /// Represents a node in the generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the value of the node.</typeparam>
    public NodeObsolete(T value)
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
    private class Node<T>
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
        internal Node<T>? Next { get; set; }

        /// <summary>
        /// Represents a node in the generic linked list.
        /// </summary>
        /// <typeparam name="T">The type of the value of the node.</typeparam>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// Represents the head of a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the linked list.</typeparam>
    private Node<T>? Head { get; set; }

    /// <summary>
    /// The tail node of a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the linked list.</typeparam>
    private Node<T>? Tail { get; set; }

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
        var newNode = new Node<T>(value);

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
        var newNode = new Node<T>(value);

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

    /// <summary>
    /// Prints the values of each node in a linked list and the count of nodes.
    /// </summary>
    public void PrintList()
    {
        var current = Head;
        while (current != null)
        {
            Console.WriteLine($"Current Node value: {current.Value} of type {current.Value.GetType()}");
            current = current.Next;
        }
        Console.WriteLine($"The linked list has {Count} nodes.");
    }

    /// <summary>
    /// Prints the values of each node in a linked list and the count of nodes.
    /// </summary>
    /// <param name="writer"></param>
    public void PrintList(TextWriter writer)
    {
        writer.WriteLine("Start of LinkedList print out:");

        var counter = 0;
        var current = Head;
        while (current != null)
        {
            writer.WriteLine(
                $"Node at index {counter} has value of type {current.Value.GetType()} and value: {current.Value}");
            current = current.Next;
            counter++;
        }

        writer.WriteLine($"End of LinkedList printout. The linked list has {Count} nodes in total.");
    }
}
