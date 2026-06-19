public class Solution 
{

    public int LengthOfLongestSubstring(string s) 
    {

        HashSet<char> charSet = new HashSet<char>();

        int maxLength = 0;

        for (int r = 0, l = 0; r < s.Length; r++)
        {

            while (charSet.Contains(s[r]))
                charSet.Remove(s[l++]);

            charSet.Add(s[r]);
            maxLength = Math.Max(charSet.Count, maxLength);

        }

        return maxLength;

    }

}
