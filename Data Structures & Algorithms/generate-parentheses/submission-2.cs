public class Solution 
{

    public void Explore(int openN, int closedN, int n, List<string> res, string parenthesis)
    {

        if (openN == n && closedN == n)
        {

            res.Add(parenthesis);
            return;

        }

        if (openN < n)
            Explore(openN + 1, closedN, n, res, parenthesis + "(");

        if (closedN < openN)
            Explore(openN, closedN + 1, n, res, parenthesis + ")");

    }

    public List<string> GenerateParenthesis(int n) 
    {

        List<string> res = new List<string>();

        Explore(0, 0, n, res, "");

        return res;

    }

}
