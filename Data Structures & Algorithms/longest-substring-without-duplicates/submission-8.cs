public class Solution 
{

    public int LengthOfLongestSubstring(string s) 
    {

        Dictionary<char, int> charIndices = new Dictionary<char, int>();

        int maxLength = 0;
        int l = 0;

        for (int r = 0; r < s.Length; r++)
        {

            if (charIndices.ContainsKey(s[r]) && charIndices[s[r]] >= l)
                l = charIndices[s[r]] + 1;

            charIndices[s[r]] = r;
            maxLength = Math.Max(r - l + 1, maxLength);

        }

        return maxLength;

    }

}