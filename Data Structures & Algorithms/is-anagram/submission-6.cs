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

        var dictT = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++)
        {

            if (!dictT.ContainsKey(t[i]))
                dictT.Add(t[i], 1);
            else
                dictT[t[i]]++;

        }

        foreach (char c in dictS.Keys)
        {

            if (dictT.Count != dictS.Count || !dictT.ContainsKey(c) || dictS[c] != dictT[c])
                return false;

        }

        return true;

    }
}
