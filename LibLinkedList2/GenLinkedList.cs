namespace LibLinkedList2;

/// <summary>
/// Represents a node in the generic linked list.
/// </summary>
/// <typeparam name="T">The type of the value of the node.</typeparam>
public class Node<T>
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
    public Node<T>? Next { get; set; }

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
/// Represents a generic linked list.
/// </summary>
/// <typeparam name="T">The type of the elements in the linked list.</typeparam>
public class GenLinkedList<T>
{
    /// <summary>
    /// Represents the head of a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the linked list.</typeparam>
    public Node<T>? Head { get; set; }

    /// <summary>
    /// Gets the number of nodes in the linked list.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Represents a node in the generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the value of the node.</typeparam>
    public GenLinkedList()
    {
        Head = null;
        Count = 0;
    }

    /// <summary>
    /// Adds a new node with the specified value to the end of the linked list.
    /// </summary>
    /// <typeparam name="T">The type of the value of the node.</typeparam>
    /// <param name="value">The value of the node to be added.</param>
    public void AddNode(T value)
    {
        Node<T> newNode = new Node<T>(value);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Count++;
    }

    /// <summary>
    /// Prints the values of each node in a linked list and the count of nodes.
    /// </summary>
    public void PrintList()
    {
        Node<T> current = Head;
        while (current != null)
        {
            Console.WriteLine($"Current Node value: {current.Value} of type {current.Value.GetType()}"); // Print the value and type of the current node
            current = current.Next;
        }
        Console.WriteLine($"The linked list has {Count} nodes.");
    }
}
