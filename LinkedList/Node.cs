namespace LinkedList;

public class Node
{
    public long Data;
    public Node Next;
    public Node Prev;

    public Node(long data)
    {
        Data = data;
        Next = null;
        Prev = null;
    }
}