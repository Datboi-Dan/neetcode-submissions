public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        
        var map = new Dictionary<string, List<string>>();

        foreach(string str in strs)
        {

            var freq = new int[26];
            foreach(char c in str)
                freq[c - 'a']++;

            var key = String.Join(',', freq);

            if(!map.ContainsKey(key))
                map.Add(key, new List<string>());
            
            map[key].Add(str);

        }

        var groups = new List<List<string>>();

        foreach(KeyValuePair<string, List<string>> kvp in map)
            groups.Add(kvp.Value);

        return groups;

    }
}
