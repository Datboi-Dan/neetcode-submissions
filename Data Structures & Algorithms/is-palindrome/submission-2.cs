public class Solution 
{
    public bool IsPalindrome(string s) 
    {
        
        var l = 0;
        var r = s.Length - 1;

        while (l < r)
        {
            
            while (l < s.Length && !Char.IsLetterOrDigit(s[l]))
                l++;

            while (r >= 0 && !Char.IsLetterOrDigit(s[r]))
                r--;

            if (l < s.Length && r >= 0 && Char.ToLower(s[l++]) != Char.ToLower(s[r--]))
                return false;

        }

        return true;

    }
}
