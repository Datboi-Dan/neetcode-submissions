public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        
        var seen = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++)
        {

            int comp = target - nums[i];
            if (seen.ContainsKey(target - nums[i]))
                return seen[comp] < i ? new int[] {seen[comp], i} : new int[] {i, seen[comp]};
            
            seen[nums[i]] = i;

        }

        return new int[] {};

    }
}
