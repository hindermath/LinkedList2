namespace LibLinkedList2;

public class Node
{
    public int Value { get; }
    public Node? Next { get; set; }

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class IntegerLinkedList
{
    public Node? Head { get; private set; }
    public int Count { get; private set; }

    public IntegerLinkedList()
    {
        Head = null;
        Count = 0;
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
        Count++;
    }
}
