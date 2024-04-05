namespace LibLinkedList2;
/// <summary>
/// Klasse Node mit generischem Typ T für die Verwendung in der generischen Klasse GenLinkedList
/// </summary>
/// <typeparam name="T"></typeparam>
public class Node<T>
{
    /// <summary>
    /// Wert des Knotens
    /// </summary>
    public T Value { get; set; }
    /// <summary>
    /// Nächtser Knoten
    /// </summary>
    public Node<T>? Next { get; set; }
    /// <summary>
    /// Konstruktor der Klasse Node mit der Übergabe des Wertes
    /// </summary>
    /// <param name="value">Wert des Knotens</param>
    public Node(T value)
    {
        Value = value;
        Next = null;
    }
}

public class GenLinkedList<T>
{
    public Node<T>? Head { get; set; }
    public int Count { get; private set; }

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
