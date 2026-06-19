public class MinStack 
{

    Stack<int> Stack { get; }
    Stack<int> Mins { get; }

    public MinStack() 
    {
        
        Stack = new Stack<int>();
        Mins = new Stack<int>();

    }
    
    public void Push(int val) 
    {

        Stack.Push(val);

        if (Mins.Count == 0 || Mins.Peek() >= val)
            Mins.Push(val);

    }
    
    public void Pop() 
    {

        if (Mins.Peek() == Top())
            Mins.Pop();

        Stack.Pop();

    }
    
    public int Top() 
    {

        return Stack.Peek();
        
    }
    
    public int GetMin() 
    {

        return Mins.Peek();
        
    }
    
}