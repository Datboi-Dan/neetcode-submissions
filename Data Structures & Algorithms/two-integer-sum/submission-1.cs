public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {

        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {

            if (!seen.ContainsKey(target - nums[i]))
                seen[nums[i]] =  i;
            else
                return new int[] {seen[target - nums[i]], i};

        }

        return new int[] {0,0};

    }
}
