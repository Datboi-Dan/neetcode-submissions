public class Solution 
{
    public int Trap(int[] height) 
    {

        int l = 0, r = height.Length - 1;
        int topl = height[l], topr = height[r];
        int totalWater = 0;

        while (l < r)
        {
            
            int water;

            if (topl > topr)
            {

                water = topr - height[--r];
                topr = height[r] > topr ? height[r] : topr;

            }
            else
            {

                water = topl - height[++l];
                topl = height[l] > topl ? height[l] : topl;

            }

            totalWater += water > 0 ? water : 0;

        }

        return totalWater;
        
    }
}
