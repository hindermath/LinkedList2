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
    public Node? First { get; private set; }
    public int Count { get; private set; }

    public IntegerLinkedList()
    {
        First = null;
        Count = 0;
    }
    public void AddNode(int value)
    {
        Node newNode = new Node(value);

        if (First == null)
        {
            First = newNode;
        }
        else
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
        Count++;
    }
}
