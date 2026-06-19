public class Solution 
{

    public int Search(int[] nums, int target) 
    {

        int low = 0, high = nums.Length - 1;
        var shift = 0;

        while (low < high)
        {

            var mid = (high - low) / 2 + low;

            if (nums[mid] <= nums[nums.Length - 1])
                high = mid;
            else
                low = mid + 1;

        }

        shift = low;
        low = 0;
        high = nums.Length - 1;

        while (low <= high)
        {

            var mid = (high - low) / 2 + low;

            if (nums[(mid + shift) % nums.Length] == target)
                return (mid + shift) % nums.Length;
            
            if (nums[(mid + shift) % nums.Length] < target)
                low = mid + 1;
            else
                high = mid - 1;

        }

        return -1;
    
    }
}
