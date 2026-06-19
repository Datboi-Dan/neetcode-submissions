public class Solution 
{

    public int LongestConsecutive(int[] nums) 
    {

        var numSet = new HashSet<int>(nums);
        var length = 0;

        while (numSet.Count > 0)
        {

            foreach (var num in numSet)
            {

                var end = num;
                var start = num;

                while (numSet.Contains(end + 1))
                    end++;

                while (numSet.Contains(start - 1))
                    start--;

                length = Math.Max(end - start + 1, length);

                while (start <= end)
                    numSet.Remove(start++);

                break;

            }

        }

        return length;

    }
    
}
