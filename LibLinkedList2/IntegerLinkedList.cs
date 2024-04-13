namespace LibLinkedList2;

public class Node(int value)
{
    public int Value { get; } = value;
    public Node? Next { get; set; }
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
}
