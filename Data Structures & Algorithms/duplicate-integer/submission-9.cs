public class Solution 
{
    public bool hasDuplicate(int[] nums) 
    {
        
        bool hasDuplicate = false;
        var numSet = new HashSet<int>();

        foreach (int num in nums)
        {

            if (numSet.Contains(num))
                return true;
            
            numSet.Add(num);

        }

        return false;

    }
}
