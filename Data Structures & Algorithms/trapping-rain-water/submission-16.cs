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
                if (height[r] > topr)
                    topr = height[r];

            }
            else
            {

                water = topl - height[++l];
                if (height[l] > topl)
                topl =  height[l];

            }

            if (water > 0)
            totalWater += water;

        }

        return totalWater;
        
    }
}
