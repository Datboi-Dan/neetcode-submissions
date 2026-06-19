public class Solution 
{ 
    
    public int FindMin(int[] nums) 
    {

        int l = 0, r = nums.Length;

        while (l < r)
        {

            var m = (r - l) / 2 + l;

            if (nums[m] <= nums[nums.Length - 1])
                r = m;
            else
                l = m + 1;

        }

        return nums[r];

    }

}
