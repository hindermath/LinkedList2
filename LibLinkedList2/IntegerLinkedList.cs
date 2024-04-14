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

    public int ImtemAt(int index)
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
