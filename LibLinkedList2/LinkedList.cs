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

    public SimpleLinkedList()
    {
        Head = null;
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
    }

    public void PrintList()
    {
        Node current = Head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
