public class Solution 
{
    public bool hasDuplicate(int[] nums) 
    {

        HashSet<int> unique = new HashSet<int>(nums);

        if (unique.Count < nums.Length) 
            return true;

        return false;

    }
}