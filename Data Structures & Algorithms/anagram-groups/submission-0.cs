public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {

        var groups = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {

            char[] strAsCharArray = str.ToCharArray();
            Array.Sort(strAsCharArray);
            string sortedStr = new string(strAsCharArray);

            if (!groups.ContainsKey(sortedStr))
                groups[sortedStr] = new List<string>();

            groups[sortedStr].Add(str);

        }

        return groups.Values.ToList();
        
    }

}
