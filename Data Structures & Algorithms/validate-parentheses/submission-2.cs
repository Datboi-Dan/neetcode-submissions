public class Solution 
{
    public bool IsValid(string s) 
    {

        var stack = new Stack<char>();

        foreach (char c in s)
        {

            char popped;

            if (c == ')' && (!stack.TryPop(out popped) || popped != '('))
                return false;
            else if (c == '}' && (!stack.TryPop(out popped) || popped != '{'))
                return false;
            else if (c == ']' && (!stack.TryPop(out popped) || popped != '['))
                return false;
            else if (c == '(' || c == '{' || c == '[')
                stack.Push(c);

        }

        return stack.Count == 0;

    }
}
