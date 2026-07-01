public class MinStack 
{

    StackNode _stackTop;

    public MinStack() 
    {
        
        _stackTop = null;

    }
    
    public void Push(int val) 
    {

        _stackTop = new StackNode(val, _stackTop, Math.Min(_stackTop is null ? val : _stackTop.Min, val));

    }
    
    public void Pop() 
    {

        _stackTop = _stackTop.Next;

    }
    
    public int Top() 
    {

        return _stackTop.Value;
        
    }
    
    public int GetMin() 
    {

        return _stackTop.Min;
        
    }
    
}

public class StackNode
{

    public int Value { get; }
    public StackNode Next { get; }
    public int Min { get; }
    
    public StackNode(int value = 0, StackNode next = null, int min = 0)
    {

        Min = min;
        Value = value;
        Next = next;

    }

}