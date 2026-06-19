public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {

        var pproducts = new int[nums.Length];
        var sproducts = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {

            pproducts[i] = i == 0 ?  1 : pproducts[i - 1] * nums[i - 1];
            sproducts[sproducts.Length - i - 1] = i == 0 ? 1 : sproducts[sproducts.Length - i] * nums[nums.Length - i];

        }

        var output = new int[nums.Length];

        for (int i = 0; i < output.Length; i++)
            output[i] = pproducts[i] * sproducts[i];

        return output;
        
    }
}
