public class MinStack 
{

    Stack<int> innerStack;
    Stack<int> minStack;

    public MinStack() 
    {

        innerStack = new Stack<int>();
        minStack = new Stack<int>();
        
    }
    
    public void Push(int val) 
    {

        innerStack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek())
            minStack.Push(val);
        
    }
    
    public void Pop() 
    {
        
        if (minStack.Peek() == innerStack.Pop())
            minStack.Pop();

    }
    
    public int Top() 
    {

        return innerStack.Peek();
        
    }
    
    public int GetMin() 
    {

        return minStack.Peek();
        
    }

}
