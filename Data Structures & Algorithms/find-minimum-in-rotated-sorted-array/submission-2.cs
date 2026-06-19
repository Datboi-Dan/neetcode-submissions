public class Solution 
{ 
    
    public int FindMin(int[] nums) 
    {

        int l = 0, r = nums.Length;
        var shift = 0;

        while (l < r)
        {

            var m = (r - l) / 2 + l;

            if (nums[m] <= nums[nums.Length - 1])
                r = m;
            else
                l = m + 1;

            shift = r;

        }

        return nums[shift];

    }

}
