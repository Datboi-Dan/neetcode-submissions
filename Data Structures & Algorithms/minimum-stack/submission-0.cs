public class MinStack 
{

    Node top;
    Stack<int> Mins { get; init;}

    public MinStack() 
    {
        
        top = null;
        Mins = new Stack<int>();

    }
    
    public void Push(int val) 
    {

        top = new Node(val, top);
        if (Mins.Count == 0 || Mins.Peek() >= val)
            Mins.Push(val);

    }
    
    public void Pop() 
    {

        if (Mins.Peek() == Top())
            Mins.Pop();

        top = top.Next;

    }
    
    public int Top() 
    {

        return top.Value;
        
    }
    
    public int GetMin() 
    {

        return Mins.Peek();
        
    }
}

public class Node
{

    public int Value { get; set; }
    public Node Next { get; set; }
    
    public Node(int value = 0, Node next = null)
    {

        Value = value;
        Next = next;

    }

}
