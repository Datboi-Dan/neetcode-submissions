public class Solution 
{

    public int Search(int[] nums, int target) 
    {

        int low = 0, high = nums.Length;
        var shift = 0;

        while (low < high)
        {

            var m = (high - low) / 2 + low;

            if (nums[m] <= nums[nums.Length - 1])
                high = m;
            else
                low = m + 1;

            shift = high;

        }

        if (target <= nums[nums.Length - 1])
        {

            low = shift;
            high = nums.Length - 1;

            while (low <= high)
            {

                var m = (high - low) / 2 + low;

                if (nums[m] == target)
                    return m;
                else if (nums[m] > target)
                    high = m - 1;
                else
                    low = m + 1;
 
            }

        }
        else
        {

            low = 0;
            high = shift - 1;

            while (low <= high)
            {

                var m = (high - low) / 2 + low;

                if (nums[m] == target)
                    return m;
                else if (nums[m] > target)
                    high = m - 1;
                else
                    low = m + 1;

            }

        }

        return -1;
        
    }
}
