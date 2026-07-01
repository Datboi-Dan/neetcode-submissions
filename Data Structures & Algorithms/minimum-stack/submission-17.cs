public class MinStack 
{

    Stack<int> _innerStack;
    Stack<int> _minStack;

    public MinStack() 
    {

        _innerStack = new Stack<int>();
        _minStack = new Stack<int>();
        
    }
    
    public void Push(int val) 
    {

        _innerStack.Push(val);
        if (_minStack.Count == 0 || val <= _minStack.Peek())
            _minStack.Push(val);
        
    }
    
    public void Pop() 
    {
        
        if (_minStack.Peek() == _innerStack.Pop())
            _minStack.Pop();

    }
    
    public int Top() 
    {

        return _innerStack.Peek();
        
    }
    
    public int GetMin() 
    {

        return _minStack.Peek();
        
    }

}
