namespace LibLinkedList2;

public class Node
{
    public int Value { get; set; }
    public Node? Next { get; set; }

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class SimpleLinkedList
{
    public Node? Head { get; set; }
    public int Count { get; private set; }

    public SimpleLinkedList()
    {
        Head = null;
        Count = 0; // Initialize the count to 0
    }
    public void AddNode(int value)
    {
        Node newNode = new Node(value);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node current = Head;
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
        Node current = Head;
        while (current != null)
        {
            Console.WriteLine($"Current Node value: {current.Value} of type {current.Value.GetType()}"); // Print the value and type of the current node
            current = current.Next;
        }
        Console.WriteLine($"The linked list has {Count} nodes.");
    }
}
