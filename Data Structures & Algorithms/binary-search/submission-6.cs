public class Solution 
{
    public int Search(int[] nums, int target) 
    {

        var curr = nums.Length / 2;
        int l = 0, r = nums.Length;

        while (curr >= l && curr < r)
        {

            if (nums[curr] == target)
                return curr;

            if (nums[curr] > target)
            {

                r = curr;
                curr = (r - l) / 2 + l;
                continue;

            }

            l = curr + 1;
            curr = (r - l) / 2 + l;

        }

        return -1;
        
    }
}