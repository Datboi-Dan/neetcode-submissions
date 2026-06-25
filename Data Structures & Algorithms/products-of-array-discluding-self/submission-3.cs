public class Solution 
{
    public int[] ProductExceptSelf(int[] nums) 
    {

        if (nums.Length == 0)
            return nums;

        var pre = new int[nums.Length];
        var post = new int[nums.Length];
        var prod = new int[nums.Length];

        pre[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            pre[i] = pre[i - 1] * nums[i];
        }
        post[nums.Length - 1] = nums[nums.Length - 1];    
        for (int i = nums.Length - 2; i >= 0; i--)
            post[i] = post[i + 1] * nums[i];

        for (int i = 0; i < nums.Length; i++)
        {

            if (i > 0 && i < nums.Length - 1)
                prod[i] = pre[i - 1] * post[i + 1];
            else
                prod[i] = i > 0 ? pre[i - 1] : post[i + 1];

        }

        return prod;

    }
}
