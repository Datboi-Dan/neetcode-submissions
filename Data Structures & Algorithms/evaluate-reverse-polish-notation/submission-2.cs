public class Solution 
{

    public int EvalRPN(string[] tokens) 
    {

        var parser = new Stack<int>();

        var operators = new Dictionary<string, Func<int, int, int>>
        {

            ["+"] = (a, b) => b + a,
            ["-"] = (a, b) => b - a,
            ["*"] = (a, b) => b * a,
            ["/"] = (a, b) => b / a

        };

        foreach (string str in tokens)
        {

            if (operators.ContainsKey(str))
                parser.Push(operators[str](parser.Pop(), parser.Pop()));
            else
                parser.Push(Convert.ToInt32(str));

        }

        return parser.Pop();
        
    }

}
