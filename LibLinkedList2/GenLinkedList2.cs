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

    public GenLinkedList()
    {
        Head = null;
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
    }

    public void PrintList()
    {
        Node<T> current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
