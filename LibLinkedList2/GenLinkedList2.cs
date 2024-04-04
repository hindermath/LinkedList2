using System.Reflection;

namespace LibLinkedList2;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Next { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}

public class GenLinkedList<T>
{
    public Node<T>? Head { get; set; }
    public int Count { get; private set; } // Initialize the count to 0

    public GenLinkedList()
    {
        Head = null;
        Count = 0; // Initialize the count to 0
    }
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
        Count++; // Increment the count when a new node is added
    }

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
