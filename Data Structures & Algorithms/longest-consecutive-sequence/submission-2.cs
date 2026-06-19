public class Solution 
{

    public int LongestConsecutive(int[] nums) 
    {

        var numSet = new HashSet<int>(nums);
        var length = 0;

        
        for (int i = 0; i < nums.Length; i++)
        {

            var end = nums[i];
            var start = nums[i];

            while (numSet.Contains(end + 1))
                end++;

            while (numSet.Contains(start - 1))
                start--;

            length = Math.Max(end - start + 1, length);

            while (start <= end)
                numSet.Remove(start++);

            if (numSet.Count == 0)
                break;

        }

        return length;

    }
    
}
