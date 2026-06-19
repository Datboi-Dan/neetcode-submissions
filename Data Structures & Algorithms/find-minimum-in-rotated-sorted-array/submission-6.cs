public class Solution 
{ 
    
    public int FindMin(int[] nums) 
    {

        int l = 0, r = nums.Length - 1;
        
        while (l < r)
        {

            var mid = (r - l) / 2 + l;

            if (nums[mid] <= nums[nums.Length - 1])
                r = mid;
            else
                l = mid + 1;

        }

        return nums[l];


    }

}
