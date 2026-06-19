public class Solution 
{
    public bool IsValid(string s) 
    {

        var dictionary = new Dictionary<char, char>
        {

            [')'] = '(',
            ['}'] = '{',
            [']'] = '['

        };
        var stack = new Stack<char>();

        foreach (char c in s)
        {

            if (dictionary.ContainsKey(c))
            {

                if (stack.Count < 1 || stack.Pop() != dictionary[c])
                    return false;

            }
            else
                stack.Push(c);

        }

        return stack.Count == 0;

    }
}
