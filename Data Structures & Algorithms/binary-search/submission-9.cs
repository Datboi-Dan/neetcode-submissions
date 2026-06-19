public class Solution 
{
    public int Search(int[] nums, int target) 
    {

        int low = 0, high = nums.Length;

        while (low < high)
        {

            var mid = (high + low) / 2;
            if (nums[mid] == target)
                return mid;

            if (nums[mid] > target)
            {

                high = mid;
                continue;

            }

            low = mid + 1;

        }

        return -1;
        
    }
}