public class Solution 
{

    public int MaxArea(int[] heights) 
    {

        int l = 0, r = heights.Length - 1, maxWater = 0;

        while (l < r)
        {

            var currWater = Math.Min(heights[l], heights[r]) * (r - l);

            maxWater = Math.Max(currWater, maxWater);

            if (heights[l] >= heights[r])
                r--;
            else
                l++;


        }

        return maxWater;
        
    }
    
}


