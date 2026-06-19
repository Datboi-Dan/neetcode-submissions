public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {

        var occurrences = new Dictionary<char, int>();

        foreach (char c in s)
        {

            if (!occurrences.ContainsKey(c))
                occurrences.Add(c, 0);
            
            occurrences[c]++;

        }

        foreach (char c in t)
        {

            if (!occurrences.ContainsKey(c) || occurrences[c] == 0)
                return false;

            occurrences[c]--;

        }

        foreach (KeyValuePair<char, int> kvp in occurrences)
        {

            if (kvp.Value != 0)
                return false;

        }

        return true;

    }
}
