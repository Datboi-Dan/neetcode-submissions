public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {

        var groups = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {

            int[] charCount = new int[26];

            foreach (char c in str)
                charCount[c - 'a']++;

            string key = string.Join(',', charCount);

            if (!groups.ContainsKey(key))
                groups[key] = new List<string>();

            groups[key].Add(str);

        }

        return groups.Values.ToList();
        
    }

}
