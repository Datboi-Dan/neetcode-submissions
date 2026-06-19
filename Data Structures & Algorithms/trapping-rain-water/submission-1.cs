public class Solution {
    public int Trap(int[] height) 
    {

        int water = 0;

        int l = 0, r = height.Length - 1;
        
        int heightL = height[l], heightR = height[r]; 

        while (l < r)
        {

            if (height[l] < height[r])
            {

                l++;

                heightL = Math.Max(height[l], heightL);

                if (height[l] < heightL)
                    water += heightL - height[l];

            }
            else
            {

                r--;

                heightR = Math.Max(height[r], heightR);

                if (height[r] < heightR)
                    water += heightR - height[r];

            }

        }

        return water;

    }
}
