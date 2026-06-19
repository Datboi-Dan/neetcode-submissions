public class Solution 
{
    public int Search(int[] nums, int target) 
    {

        int low = 0, high = nums.Length - 1;

        while (low <= high)
        {

            var mid = (high - low) / 2  + low;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] > target)
                high = mid - 1;
            else
                low = mid + 1;

        }

        return -1;
        
    }
}