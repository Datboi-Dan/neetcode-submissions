public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {

        var product = 1;
        foreach (var num in nums)
            product *= num == 0 ? 1 : num;

        var output = new int[nums.Length];

        var zeroCounter = Array.FindAll(nums, n => n == 0).Length;

        for (int i = 0; i < output.Length; i++)
        {

            if (zeroCounter == 1)
                output[i] = nums[i] == 0 ? product : 0;
            else if (zeroCounter == 0)
                output[i] = product / nums[i];

        }

        return output;
        
    }
}