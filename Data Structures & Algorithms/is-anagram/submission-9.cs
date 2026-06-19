public class Solution {
    public bool IsAnagram(string s, string t) 
    {

        var dictS = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {

            if (!dictS.ContainsKey(s[i]))
                dictS.Add(s[i], 1);
            else
                dictS[s[i]]++;

        }

        foreach (char c in t)
        {

            if (!dictS.ContainsKey(c))
                return false;
            else 
                dictS[c]--;

        }

        foreach (char c in dictS.Keys)
            if (dictS[c] != 0)
                return false;

        return true;

    }
}
