namespace LibLinkedList2;

/// <summary>
/// Represents a node in an integer linked list.
/// </summary>
/// <param name="value">The value of the node.</param>
public class Node(int value)
{
    /// <summary>
    /// Represents the value of a node in an integer linked list.
    /// </summary>
    public int Value { get; } = value;

    /// <summary>
    /// Represents a node in an integer linked list.
    /// </summary>
    public Node? Next { get; set; }
}

/// <summary>
/// Represents a linked list that stores integer values.
/// </summary>
public class IntegerLinkedList
{
    /// <summary>
    /// Represents the head of a generic linked list.
    /// </summary>
    public Node? First { get; private set; }

    /// <summary>
    /// Gets the number of nodes in the linked list.
    /// </summary>
    public int Count { get; private set; }

    /// <summary>
    /// Adds a new node with the specified value to the end of the linked list.
    /// </summary>
    /// <param name="value">The value of the node to add.</param>
    public void AddNode(int value)
    {
        var newNode = new Node(value);

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
    /// Retrieves the value at the specified index in the linked list.
    /// </summary>
    /// <param name="index">The zero-based index of the value to retrieve.</param>
    /// <returns>The value at the specified index.</returns>
    public int ItemAt(int index)
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
        for (int i = 0; i < index; i++)
        {
            currentNode = currentNode.Next;

            if (currentNode is null)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index was too large for the list");
            }
        }
        return currentNode.Value;
    }
}
