public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {

        var triplets = new List<List<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {

            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            var complement = -nums[i];

            int l = i + 1, r = nums.Length - 1;

            while (l < r)
            {

                var sum = nums[l] + nums[r];

                if (sum == complement && (r == nums.Length - 1 || nums[r] != nums[r + 1]))
                    triplets.Add(new List<int>{nums[i], nums[l], nums[r--]});
                else if (sum < complement)
                    l++;
                else
                    r--;

            }

        }

        return triplets;
        
    }
}
