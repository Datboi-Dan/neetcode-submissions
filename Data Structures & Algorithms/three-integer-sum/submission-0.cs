public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {

        var triplets = new Dictionary<string, List<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {

            var target = 0 - nums[i];

            int l = i + 1, r = nums.Length - 1;

            while (l < r)
            {

                var sum = nums[l] + nums[r];

                var triplet = new List<int>(new int[] {nums[i], nums[l], nums[r]});

                if (sum == target && !triplets.ContainsKey(String.Join("", triplet)))
                    triplets.Add(String.Join("", triplet), triplet);
                else if (sum < target)
                    l++;
                else
                    r--;

            }

        }

        return triplets.Values.ToList();
        
    }
}
