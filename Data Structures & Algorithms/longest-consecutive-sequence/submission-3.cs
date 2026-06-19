public class Solution 
{

    public int LongestConsecutive(int[] nums) 
    {

        var numSet = new HashSet<int>(nums);
        var startingNums = new HashSet<int>();
        var length = 0;

        foreach (var num in numSet)
            if (!numSet.Contains(num - 1))
                startingNums.Add(num);
        
        foreach (var num in startingNums)
        {
            
            var end = num;
            
            while (numSet.Contains(end + 1))
                end++;

            length = Math.Max(end - num + 1, length);

        }

        return length;

    }
    
}
