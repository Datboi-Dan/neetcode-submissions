public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {

        var numSet = new HashSet<int>(nums);
        var starts = new List<int>();
        int longest = 0;

        foreach (int num in numSet)
        {

            if (!numSet.Contains(num - 1))
                starts.Add(num);

        }

        foreach (int num in starts)
        {

            int length = 1;
            
            while (numSet.Contains(num + length))
                length++;

            if (length > longest)
                longest = length;

        }

        return longest;

    }
}
