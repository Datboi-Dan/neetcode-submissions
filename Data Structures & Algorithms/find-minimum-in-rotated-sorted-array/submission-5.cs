public class Solution 
{ 
    
    public int FindMin(int[] nums) 
    {

        int l = 0, r = nums.Length - 1;
        int shift = 0;

        if (nums[l] > nums[r])
        {

            while (l <= r)
            {

                var mid = (r - l) / 2 + l;

                if (nums[(mid + 1) % nums.Length] < nums[mid])
                {

                    shift = (mid + 1) % nums.Length;
                    break;

                }

                if (nums[mid] < nums[nums.Length - 1])
                    r = mid - 1;
                else
                    l = mid + 1;
            
            }

        }

        return nums[shift];

    }

}
